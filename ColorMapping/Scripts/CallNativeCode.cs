
using UnityEngine;
using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Collections;
using UnityEngine.Networking;

public class CallNativeCode : MonoBehaviour
{
    [DllImport("AirarColorMap")]
    private static extern void ImageProc(string imgPath, float[] src, float[] dst, int height, int width);

    private Texture2D myTe;
    public Texture2D m_Texture;
    public Renderer m_Renderer;
    

    private void Start()
    {
        myTe = new Texture2D(m_Texture.width, m_Texture.height, TextureFormat.ARGB32, false);

        float[] src = new float[] { 123, 123, 389, 123, 126, 420, 391, 416 };
        float[] dst = new float[] { 0, 0, m_Texture.width, 0, 0, m_Texture.height, m_Texture.width, m_Texture.height };


        //스샷 찍기 
        File.WriteAllBytes(Application.persistentDataPath + "/test_img00.jpg", m_Texture.EncodeToJPG());

        //이미지 보정
        ImageProc(Application.persistentDataPath + "/test_img00.jpg", src, dst,m_Texture.height,m_Texture.width);

        string path = Path.Combine(Application.persistentDataPath, "test_img00.jpg");
        //보정된 이미지 3d객체에 적용
        if (File.Exists(path))
        {
            StartCoroutine(LoadTexture(path));
        }
    }

    IEnumerator LoadTexture(string path)
    {
        
        UnityWebRequest www = UnityWebRequestTexture.GetTexture("file://" + path);
        yield return www.SendWebRequest();

        if (!www.isNetworkError)
        {
            // Get text content like this:
            //myTe.LoadImage(www.downloadHandler.data);
            myTe = DownloadHandlerTexture.GetContent(www);
            myTe.Apply();
            m_Renderer.material.mainTexture = myTe;
        }
    }

}
