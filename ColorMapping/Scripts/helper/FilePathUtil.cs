using System.IO;
using UnityEngine;

public static class FilePathUtil
{
    private static string FOLDER_NAME = "AIR_AR";

    // Get Android Internal Path
    public static string GetAndroidInternalFilesDir()
    {
        string[] potentialDirectories = new string[]
        {
            "/mnt/sdcard",
            "/sdcard",
            "/storage/sdcard0",
            "/storage/sdcard1"
        };

        if (Application.platform == RuntimePlatform.Android)
        {
            for (int i = 0; i < potentialDirectories.Length; i++)
            {
                if (Directory.Exists(potentialDirectories[i]))
                {
                    return potentialDirectories[i];
                }
            }
        }
        return "";
    }

    // Create File Save Path
    public static string GetImageSavePath(string fileName)
    {
        string strPath;

#if UNITY_ANDROID && !UNITY_EDITOR
        string dirPath = Path.Combine(GetAndroidInternalFilesDir(), FOLDER_NAME);
        if (!System.IO.Directory.Exists(dirPath))
        {
            System.IO.Directory.CreateDirectory(dirPath);
        }

        strPath = Path.Combine(dirPath, fileName);

#elif UNITY_IOS && !UNITY_EDITOR
        strPath = Path.Combine(Application.persistentDataPath, fileName);
#else
        strPath = Path.Combine(Application.persistentDataPath, fileName);
#endif
        return strPath;
    }
}