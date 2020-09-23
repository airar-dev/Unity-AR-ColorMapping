using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if USE_ARFOUNDATION
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
#endif

public class ARFoundationColorMapping : MonoBehaviour
{
#if USE_ARFOUNDATION
    public ARTrackedImageManager imageManager;
#endif

    public GameObject arContents;
    public GameObject drawObj;

    public int realWidth;
    public int realHeight;

    private GameObject cube;

    void Start()
    {
#if USE_ARFOUNDATION
        IReferenceImageLibrary imageLibrary = imageManager.referenceLibrary;
        float targetWidth = imageLibrary[0].width;
        float targetHeight = imageLibrary[0].height;

        cube = CreateCubeForARFoundationTarget(this.gameObject, targetWidth, targetHeight);
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
    /// Create a full size cube on the ARFoundation marker image
    /// </summary>
    /// <param name="targetWidth">marker image width</param>
    /// <param name="targetHeight">marker image height</param>
    public GameObject CreateCubeForARFoundationTarget(GameObject parentObj, float targetWidth, float targetHeight)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.GetComponent<Renderer>().material = AirarManager.Instance.transparentMat;
        cube.transform.SetParent(parentObj.transform);
        cube.transform.localPosition = Vector3.zero;
        cube.transform.localScale = new Vector3(targetWidth, 0.001f, targetHeight);

        return cube;
    }
}
