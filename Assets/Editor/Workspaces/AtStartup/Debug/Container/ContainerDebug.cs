#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;


namespace project_pkdsim.Editor.Workspaces.AtStartup.Debug.Container
{
	[InitializeOnLoad]
	public class ContainerDebug : MonoBehaviour
	{
		public void ContainerDebugger()
		{
			EditorApplication.update += LogEditorState;
		}

		public static void LogEditorState()
		{
			if (EditorWindow.focusedWindow != null)
			{
				UnityEngine.Debug.Log($"[FOCUS] Window: {EditorWindow.focusedWindow.titleContent.text}");
			}

			if (EditorWindow.mouseOverWindow != null)
			{
                UnityEngine.Debug.Log($"[MOUSE OVER] Window: {EditorWindow.mouseOverWindow.titleContent.text}");
			}
		}
		public void ContainerDebuggerInitializer()
		{
			ContainerDebugger();
			LogEditorState();
		}
	}
}
#endif