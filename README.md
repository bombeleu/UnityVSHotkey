# UnityVSHotkey
A two-part plugin that lets you switch between Unity and Visual Studio by pressing CTRL-1. The Unity Editor script brings VS to the foreground when in Unity, and the VS plugin brings Unity to the foreground when in VS.

This package is tested on Windows 8 using Visual Studio 2013 Community Edition with Visual Studio 2013 Tools for Unity and Unity v5.0.1f1.

The Unity script works out of the box, just drag the UnityVSHotkey folder into your Assets folder. You can now press CTRL-1 in Unity to focus VS (or open it if it isn't already).

To install the VS plugin, either go to the menu and select UnityVSHotkey -> Install VS Plugin or open the GoToUnity Visual Studio Extension in the UnityVSHotkey directory. The plugin can be deleted after installation. You can now press CTRL-1 in VS to focus Unity (it won't open if it isn't already).

The source code for the VS Plugin is in the folder VSPluginSource. You can delete it if you don't want to modify it.

If you want to change the shortcut keybinding, you'll need to change it on both the Unity side and the VS side.

In Unity:    
You will see a line like this inside Hotkey.cs:
```
[MenuItem("UnityVSHotkey/Go to Visual Studio %1")]
```

Change %1 to whatever you want.

In VS:   
Take the VS zipped source code outside of the Unity project and unzip it. In the GoToUnity folder there is a file called GoToUnity.vsct. Look for: 
```
<KeyBindings>
  <KeyBinding guid="guidGoToUnityCmdSet" id="GoToUnity"    editor="guidVSStd97" key1="1" mod1="CONTROL"/>
</KeyBindings>
```
Change key1 and mod1 to whatever you want. Open the solution in VS and rebuild. The new installer can be found at VSPluginSourceCode -> GoToUnity -> bin -> Debug/Release.

 I would make a Unity menu option for changing both hotkeys in one go, except I'm not sure it's possible.


