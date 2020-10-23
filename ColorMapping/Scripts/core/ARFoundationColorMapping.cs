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

    public GameObject arPrefabs;

    public int realWidth;
    public int realHeight;

    private GameObject arContents;
    private GameObject drawObj;

    private GameObject cube;

#if USE_ARFOUNDATION
    void Start()
    {
        imageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        ARTrackedImage trackedImage = null;

        for (int i = 0; i < eventArgs.added.Count; i++)
        {
            trackedImage = eventArgs.added[i];
            string imgName = trackedImage.referenceImage.name;

            if(imgName == "sw-12")
            {
                arContents = Instantiate(arPrefabs, trackedImage.transform);
                cube = CreateCubeForARFoundationTarget(this.gameObject, trackedImage.size.x, trackedImage.size.y, trackedImage.transform);
            }
        }

        for (int i = 0; i < eventArgs.updated.Count; i++)
        {
            trackedImage = eventArgs.updated[i];

            if (trackedImage.trackingState == TrackingState.Tracking)
            {
                arContents.SetActive(true);
            }
            else
            {
                arContents.SetActive(false);
            }
        }

        for (int i = 0; i < eventArgs.removed.Count; i++)
        {
            arContents.SetActive(false);
        }
    }
#endif

    public void Play()
    {
        float[] srcValue = AirarManager.Instance.CalculateMarkerImageVertex(cube);

        Texture2D screenShotTex = ScreenShot.GetScreenShot(arContents);

        AirarManager.Instance.ProcessColoredMapTexture(screenShotTex, srcValue, realWidth, realHeight, (resultTex) =>
        {
            drawObj = GameObject.FindGameObjectWithTag("coloring");
            drawObj.GetComponent<Renderer>().material.mainTexture = resultTex;
        });
    }

    /// <summary>
    /// Create a full size cube on the ARFoundation marker image
    /// </summary>
    /// <param name="targetWidth">marker image width</param>
    /// <param name="targetHeight">marker image height</param>
    public GameObject CreateCubeForARFoundationTarget(GameObject parentObj, float targetWidth, float targetHeight, Transform trans)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.GetComponent<Renderer>().material = AirarManager.Instance.transparentMat;
        cube.transform.SetParent(trans);
        cube.transform.localPosition = trans.localPosition;
        cube.transform.localScale = new Vector3(targetWidth, 0.001f, targetHeight);

        return cube;
    }
}
