using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.IO;
using UnityEngine.Networking;
using System;

public class AirarManager : AirarSingleton<AirarManager>
{
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

        string imgPath = FilePathUtil.GetImageSavePath("airar.jpg");

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

}
