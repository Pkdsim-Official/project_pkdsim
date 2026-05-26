using project_pkdsim.Editor.Workspaces.Namespace;
using project_pkdsim.Editor.Workspaces.AASys;
using project_pkdsim.Editor.Workspaces.AtStartup;
using UnityEngine;

namespace project_pkdsim.Editor.Workspaces
{
	public class EditorWorkspaces : MonoBehaviour 
	{
		private Namespacer namespacer;
		private Editor_AAsys editor_AAsys;
		
		private AtStartupEditor atStartupEditor;

		private void Init()
		{
			namespacer.NamespaceI();
			editor_AAsys.Editor_AAsysI();
			atStartupEditor.OnStartup();
		}

		public void EditorWorkspacesInitializer() 
		{
			Init();
		}
	}
}