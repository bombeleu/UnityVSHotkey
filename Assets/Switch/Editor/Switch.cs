using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEditorInternal;

public class Switch : EditorWindow {
	
	[MenuItem("Switch/Switch! %e")]
	static void SwitchToIde() {
//		AssetDatabase.OpenAsset(this);
		UnityEditorInternal.InternalEditorUtility.OpenFileAtLineExternal("", 0);
	}
}
