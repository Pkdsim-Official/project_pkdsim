using project_pkdsim.Editor.Workspaces.AtStartup.Tooltips;
using project_pkdsim.Editor.Workspaces.AtStartup.Debug;
using UnityEngine;

namespace project_pkdsim.Editor.Workspaces.AtStartup
{
	public class AtStartupEditor : MonoBehaviour
	{
		private TooltipEditor TooltipEditor;
		private DebugEditor DebugEditor;
		public void OnStartup()
		{
			TooltipEditor.TooltipEditorInitializer();
			DebugEditor.DebugEditorInitializer();
		}
	}
}