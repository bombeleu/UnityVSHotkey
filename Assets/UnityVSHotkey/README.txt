This package is tested on Windows using Visual Studio 2013 Community Edition 
with Visual Studio 2013 Tools for Unity and Unity v5.0.1f1.

There are two parts to the package. 
There is a Unity script that brings VS to the foreground, 
and an VS plugin that brings Unity to the foreground.

The Unity script works out of the box,
just drag the unzipped UnityVSHotkey folder into your Assets folder.
You can now press CTRL-1 in Unity to focus VS (or open it if it isn't already).

To install the VS plugin, either go to the menu and select UnityVSHotkey -> Install VS Plugin
or open the GoToUnity Visual Studio Extension in the UnityVSHotkey directory. 
The plugin can be deleted after installation. 
You can now press CTRL-1 in VS to focus Unity (it won't open if it isn't already).

The zipped up source code for the VS Plugin is also included. 
You can delete it if you want, but you're free to modify it as you wish. 
If you just want to change the shortcut keybinding, you'll need to change it on both the Unity side and the VS side.

In Unity:
You will see a line like this inside Hotkey.cs:
[MenuItem("UnityVSHotkey/Go to Visual Studio %1")]

Change %1 to whatever you want.

In VS:
Take the VS zipped source code outside of the Unity project and unzip it. 
In the GoToUnity folder there is a file called GoToUnity.vsct. 
Look for 
  <KeyBindings>
    <KeyBinding guid="guidGoToUnityCmdSet" id="GoToUnity"    editor="guidVSStd97" key1="1" mod1="CONTROL"/>
  </KeyBindings>

 Change key1 and mod1 to whatever you want. Open the solution in VS and change the Build -> Build Solution 
 (you'll probably want to go to Build -> Configuration Manager to change the Active Solution Configuration to Release). 
 The new installer can be found at VSPluginSourceCode -> GoToUnity -> bin -> Debug/Release.

 I would make a menu option for changing both hotkeys in one go, except I'm not sure it's possible.

 Happy Coding!
 William Kwan
 http://www.voidupdate.com



