using project_pkdsim.Editor.Workspaces.AtStartup.Debug.Container;
using UnityEngine;

namespace project_pkdsim.Editor.Workspaces.AtStartup.Debug
{
	public class DebugEditor : MonoBehaviour
	{
		private ContainerDebug containerDebug;
		public void DebugEditorInitializer()
		{
			Get_ContainerDebugger();
		}
		public void Get_ContainerDebugger()
		{
			containerDebug.ContainerDebuggerInitializer();
		}
	}
}