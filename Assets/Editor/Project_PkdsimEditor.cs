using project_pkdsim.Editor.Workspaces;
using UnityEngine;

namespace project_pkdsim.Editor
{
	public class Project_PkdsimEditor : MonoBehaviour 
	{
		private EditorWorkspaces EditorWorkspaces;
		private void OnEnable()
		{
			EditorWorkspaces.EditorWorkspacesInitializer();
		}
	}
}