
using UnityEngine;
using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Collections;
using UnityEngine.Networking;

public class CallNativeCode : MonoBehaviour
{
    [DllImport("AirarColorMap")]
    private static extern void ImageProc(string imgPath, float[] src,  int height, int width);

    private Texture2D myTe;
    public Texture2D m_Texture;
    public Renderer m_Renderer;
    

    private void Start()
    {
        myTe = new Texture2D(m_Texture.width, m_Texture.height, TextureFormat.ARGB32, false);

        //float[] src = new float[] { 123, 123, 389, 123, 391, 416 ,126, 420};


        float[] src = new float[] {177.4023f, 961.2523f,851.6965f, 972.6123f,834.8322f, 1471.942f, 182.0617f, 1452.46f};
        //float[] dst = new float[] { 0, 0, m_Texture.width, 0, 0, m_Texture.height, m_Texture.width, m_Texture.height };

        AirarManager.Instance.ProcessColoredMapTexture(m_Texture, src, 1024, 1024, (tex) =>
        {
            m_Renderer.material.mainTexture = tex;
        });

        ////스샷 찍기 
        //File.WriteAllBytes(Application.persistentDataPath + "/test_img00.jpg", m_Texture.EncodeToJPG());

        ////이미지 보정
        //ImageProc(Application.persistentDataPath + "/test_img00.jpg", src,m_Texture.height,m_Texture.width);

        //string path = Path.Combine(Application.persistentDataPath, "test_img00.jpg");
        ////보정된 이미지 3d객체에 적용
        //if (File.Exists(path))
        //{
        //    StartCoroutine(LoadTexture(path));
        //}
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
