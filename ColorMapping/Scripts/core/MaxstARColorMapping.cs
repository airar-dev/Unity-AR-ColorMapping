using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if USE_MAXSTAR
using maxstAR;
#endif

public class MaxstARColorMapping : MonoBehaviour
{
#if USE_MAXSTAR
    public ImageTrackableBehaviour trackableBehaviour;
#endif

    public GameObject arContents;
    public GameObject drawObj;

    public int realWidth;
    public int realHeight;

    private GameObject cube;

    void Start()
    {
#if USE_MAXSTAR
        float targetWidth = trackableBehaviour.TargetWidth;
        float targetHeight = trackableBehaviour.TargetHeight;

        cube = CreateCubeForMaxstARTarget(this.gameObject, targetWidth, targetHeight);
#endif
    }

    public void Play()
    {
        float[] srcValue = AirarManager.Instance.CalculateMarkerImageVertex(cube);

        Texture2D screenShotTex = ScreenShot.GetScreenShot(arContents);

        AirarManager.Instance.ProcessColoredMapTexture(screenShotTex, srcValue, realWidth, realHeight, (resultTex) =>
        {
            drawObj.GetComponent<Renderer>().material.mainTexture = resultTex;
        });
    }

    /// <summary>
    /// Create a full size cube on the MaxstAR marker image
    /// </summary>
    /// <param name="targetWidth">marker image width</param>
    /// <param name="targetHeight">marker image height</param>
    public GameObject CreateCubeForMaxstARTarget(GameObject parentObj, float targetWidth, float targetHeight)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.GetComponent<Renderer>().material = AirarManager.Instance.transparentMat;
        cube.transform.SetParent(parentObj.transform);
        cube.transform.localPosition = Vector3.zero;
        cube.transform.localScale = new Vector3(targetWidth, 0.001f, targetHeight);

        return cube;
    }
}
