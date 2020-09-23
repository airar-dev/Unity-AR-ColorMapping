using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if USE_EASYAR
using easyar;
#endif

public class EasyARColorMapping : MonoBehaviour
{
#if USE_EASYAR
    public ImageTargetController imageTargetController;
#endif

    public GameObject arContents;
    public GameObject drawObj;

    public int realWidth;
    public int realHeight;

    private GameObject cube;

    void Start()
    {
#if USE_EASYAR
        imageTargetController.TargetLoad += (loadedTarget, result) =>
        {
            easyar.Image targetImage = ((loadedTarget as ImageTarget).images())[0];
            float targetWidth = (float)targetImage.width();
            float targetHeight = (float)targetImage.height();
            float targetScale = (targetHeight / targetWidth);

            cube = CreateCubeForEasyARTarget(this.gameObject, targetScale);
        };
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
    /// Create a full size cube on the EasyAR marker image
    /// </summary>
    /// <param name="targetScale">EasyAR marker image scale</param>
    public GameObject CreateCubeForEasyARTarget(GameObject parentObj, float targetScale)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.GetComponent<Renderer>().material = AirarManager.Instance.transparentMat;
        cube.transform.SetParent(parentObj.transform);
        cube.transform.localPosition = new Vector3(0f, 0f, -0.005f);
        cube.transform.localRotation = Quaternion.Euler(new Vector3(-90f, 0f, 0f));
        cube.transform.localScale = new Vector3(1f, 0.01f, targetScale);

        return cube;
    }
}
