
using UnityEngine;
using System.Runtime.InteropServices;

public class CallNativeCode : MonoBehaviour
{
    [DllImport("OpenCVBridge")]
    private static extern float MyOpenCVTestMethod();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI()
    {
        // This Line should display "Foopluginmethod: 10"
        GUI.Label(new Rect(15, 125, 450, 100), "MyOpenCVTestMethod: " + MyOpenCVTestMethod());

    }
}
