using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.IO;
using UnityEngine.Networking;
using System;

public class AirarManager : AirarSingleton<AirarManager>
{
    public Material transparentMat;

    [DllImport("AirarColorMap")]
    private static extern void ImageProc(string imgPath, float[] src, int height, int width);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="srcTexture">screenshot</param>
    /// <param name="src">float[8]</param>
    /// <param name="height">target 3d model map height size</param>
    /// <param name="width">target 3d model map width size</param>
    public void ProcessColoredMapTexture(Texture2D srcTexture ,float[] src,int height, int width,Action<Texture2D> callback)
    {

        Texture2D dstTexture = new Texture2D(width, height);

        //string imgPath = FilePathUtil.GetImageSavePath("airar.jpg");
        string imgPath = Path.Combine(Application.persistentDataPath, "airar.jpg");
        File.WriteAllBytes(imgPath, srcTexture.EncodeToJPG());
        unsafe
        {
            ImageProc(imgPath, src, height, width);
        }

        if (File.Exists(imgPath))
        {
            StartCoroutine(LoadTexture(imgPath,(www)=>
            {
                callback(DownloadHandlerTexture.GetContent(www));
            }));
        }
    }

    IEnumerator LoadTexture(string path, Action<UnityWebRequest> callback)
    {

        UnityWebRequest www = UnityWebRequestTexture.GetTexture("file://" + path);
        yield return www.SendWebRequest();

        if (!www.isNetworkError)
        {
            callback(www);
        }
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
