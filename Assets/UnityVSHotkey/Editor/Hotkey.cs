using UnityEngine;
using UnityEditor;
using System.Runtime.InteropServices;
using System;

public class Switch : EditorWindow
{
    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool SetForegroundWindow(IntPtr hwnd);

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

    private const int SW_SHOWMAXIMIZED = 3;

    //Change %1 to adjust the hotkey.
    [MenuItem("UnityVSHotkey/Go to Visual Studio %1")]
    static void FocusVisualStudio()
    {
        //In the VS plugin, we find the window handle of Unity by calling FindProcessByName. 
        //But this gives us a zero handle when searching for "devenv" in Unity (the process is found, but we don't have the window handle).
        IntPtr handle = FindWindow(null, "UnityVS." + System.IO.Directory.GetParent(Application.dataPath).Name + " - Microsoft Visual Studio");

        //VS isn't open, so open it.
        if (handle == IntPtr.Zero)
        {
            UnityEditorInternal.InternalEditorUtility.OpenFileAtLineExternal("", 0);
            return;
        }

        ShowWindow(handle, SW_SHOWMAXIMIZED);
        SetForegroundWindow(handle);
    }

    [MenuItem("UnityVSHotkey/Install VS Plugin")]
    static void InstallVSPlugin()
    {
        string installerPath = Application.dataPath + System.IO.Path.DirectorySeparatorChar + "UnityVSHotkey" + System.IO.Path.DirectorySeparatorChar + "GoToUnity.vsix";
        if (System.IO.File.Exists(installerPath)) System.Diagnostics.Process.Start(installerPath);
        else UnityEngine.Debug.Log("Installer not found");
    }
}
