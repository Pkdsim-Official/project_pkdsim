using project_pkdsim.Editor.Workspaces.Namespace;
using UnityEngine;

namespace project_pkdsim.Editor.Workspaces
{
	public class EditorWorkspaces : MonoBehaviour 
	{
		private Namespacer namespacer;
		private Editor_AAsys editor_AAsys;
		private void Init() 
		{
			namespacer.NamespaceI();
			editor_AAsys.Editor_AAsysI();
		}

		public void EditorWorkspacesInitializer() 
		{
			Init();
		}
	}
}