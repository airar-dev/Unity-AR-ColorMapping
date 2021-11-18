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

    public int realWidth;
    public int realHeight;

    private GameObject drawObj;
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
        float[] srcValue = AirarManager.Instance.CalculateMarkerImageVertex(cube);

        Texture2D screenShotTex = ScreenShot.GetScreenShot(arContents);

        AirarManager.Instance.ProcessColoredMapTexture(screenShotTex, srcValue, realHeight, realWidth, (resultTex) =>
        {
            drawObj = GameObject.FindGameObjectWithTag("coloring");
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
        cube.GetComponent<Renderer>().material = AirarManager.Instance.transparentMat;
        cube.transform.SetParent(parentObj.transform);
        cube.transform.localPosition = Vector3.zero;
        cube.transform.localScale = new Vector3(targetWidth, 0.001f, targetHeight);

        return cube;
    }
}
