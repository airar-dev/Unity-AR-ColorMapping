
using UnityEngine;
using System.Runtime.InteropServices;
using System;
using System.IO;

public class CallNativeCode : MonoBehaviour
{
    [DllImport("AirarColorMap")]
    private static extern float MyOpenCVTestMethod();


    [DllImport("AirarColorMap")]
    private static extern IntPtr GetWarpTexture(IntPtr myTexture, double[] src, double[] dst, int height, int width);

    public Texture2D m_Texture;
    public Renderer m_Renderer;
    private Texture2D testTex;

    protected Color32[] m_Pixels;
    protected GCHandle m_PixelsHandle;
    protected IntPtr m_pixelPtr;
    protected IntPtr m_tempPtr;

    //7월 13일 검증 완료된 코드
    // Start is called before the first frame update
    void Start()
    {
        //--------------------------------------------------------------------------------------//
        double[] src = new double[] { 98, 70, 414, 190, 109, 386, 433, 370 };
        double[] dst = new double[] { 0, 0, 512, 0, 0, 512, 512, 512 };

        //--------------------------------------------------------------------------------------//

        m_Pixels = m_Texture.GetPixels32();
        m_PixelsHandle = GCHandle.Alloc(m_Pixels, GCHandleType.Pinned);
        m_pixelPtr = m_PixelsHandle.AddrOfPinnedObject();


        m_tempPtr = GetWarpTexture(m_pixelPtr, src, dst, m_Texture.height, m_Texture.width);

        Texture2D myTe = new Texture2D(m_Texture.width, m_Texture.height, TextureFormat.RGBA32, false);
        myTe.LoadRawTextureData(m_tempPtr, myTe.height * myTe.width * 4);
        myTe.Apply();

        File.WriteAllBytes(Application.persistentDataPath + "/test2.jpg", myTe.EncodeToJPG());
        m_Renderer.material.mainTexture = myTe;
    }
    //7월 13일 검증 완료된 코드 여기까지


    //unsafe void TextureToCVMat(Texture2D texData)
    //{
    //    Color32[] texDataColor = texData.GetPixels32();
    //    //Pin Memory
    //    fixed (Color32* p = texDataColor)
    //    {
    //        //TextureToCVMat((IntPtr)p, texData.width, texData.height);

    //        testTex.LoadRawTextureData((IntPtr)p, m_Texture.height * m_Texture.width * 4);
    //        testTex.Apply();

    //        File.WriteAllBytes(Application.persistentDataPath + "/test2.jpg", testTex.EncodeToJPG());
    //        m_Renderer.material.mainTexture = testTex;


    //    }
    //}


    void OnGUI()
    {
        // This Line should display "Foopluginmethod: 10"
        GUI.Label(new Rect(15, 125, 450, 100), "MyOpenCVTestMethod: " + MyOpenCVTestMethod());

    }
}
