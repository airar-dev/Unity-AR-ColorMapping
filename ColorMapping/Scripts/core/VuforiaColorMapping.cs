using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if USE_VUFORIA
using Vuforia;
#endif

public class VuforiaColorMapping : MonoBehaviour
{
#if USE_VUFORIA
    public ImageTargetBehaviour imageTaget;
#endif

    public GameObject arContents;
    public GameObject drawObj;
    public Material transparentMat;

    private GameObject cube;

    void Start()
    {
#if USE_VUFORIA
        Vector2 imageTargetSize = imageTaget.GetSize();
        float targetWidth = imageTargetSize.x;
        float targetHeight = imageTargetSize.y;

        cube = CreateCubeForVuforiaTarget(this.gameObject, targetWidth, targetHeight);
#endif
    }

    public void Play()
    {
        float[] srcValue = CalculateMarkerImageVertex(cube);

        foreach (float val in srcValue)
        {
            Debug.Log(val);
        }

        Texture2D screenShotTex = ScreenShot.GetScreenShot(arContents);

        AirarManager.Instance.ProcessColoredMapTexture(screenShotTex, srcValue, 1024, 768, (resultTex) =>
        {
            drawObj.GetComponent<Renderer>().material.mainTexture = resultTex;
        });
    }

    /// <summary>
    /// Create a full size cube on the Vuforia marker image
    /// </summary>
    /// <param name="targetWidth">marker image width</param>
    /// <param name="targetHeight">marker image height</param>
    public GameObject CreateCubeForVuforiaTarget(GameObject parentObj, float targetWidth, float targetHeight)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.GetComponent<Renderer>().material = transparentMat;
        cube.transform.SetParent(parentObj.transform);
        cube.transform.localPosition = Vector3.zero;
        cube.transform.localScale = new Vector3(targetWidth, 0.001f, targetHeight);

        return cube;
    }

    /// <summary>
    /// Marker image vertex coordinate calculation
    /// </summary>
    /// <param name="cube">cube object on marker image</param>
    public float[] CalculateMarkerImageVertex(GameObject cube)
    {
        List<Vector2> vertexList = new List<Vector2>();

        Vector3[] vertices = cube.GetComponent<MeshFilter>().mesh.vertices;
        Vector2[] result = new Vector2[vertices.Length];
        for (int i = 0; i < vertices.Length; ++i)
        {
            result[i] = Camera.main.WorldToScreenPoint(cube.transform.TransformPoint(vertices[i]));
            vertexList.Add(result[i]);
        }

        // Actual Device Size
        int screenHeight = Screen.height;

        // Use mesh bottom vertices
        // 14(LU), 13(RU), 12(RD), 15(LD)
        Vector2 LU = new Vector2();
        Vector2 RU = new Vector2();
        Vector2 RD = new Vector2();
        Vector2 LD = new Vector2();
        for (int i = 0; i < vertexList.Count; i++)
        {
            if (i >= 12 && i <= 15)
            {
                LU = vertexList[14];
                RU = vertexList[13];
                RD = vertexList[12];
                LD = vertexList[15];
            }
        }

        float[] srcPosition = new float[8];
        srcPosition[0] = LU.x;
        srcPosition[1] = screenHeight - LU.y;

        srcPosition[2] = RU.x;
        srcPosition[3] = screenHeight - RU.y;

        srcPosition[4] = RD.x;
        srcPosition[5] = screenHeight - RD.y;

        srcPosition[6] = LD.x;
        srcPosition[7] = screenHeight - LD.y;

        return srcPosition;
    }
}
