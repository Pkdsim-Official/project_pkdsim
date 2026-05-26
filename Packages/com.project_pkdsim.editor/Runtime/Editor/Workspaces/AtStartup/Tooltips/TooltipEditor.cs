using project_pkdsim.Editor.Workspaces.AtStartup.Tooltips.Blocker;
using UnityEngine;

namespace project_pkdsim.Editor.Workspaces.AtStartup.Tooltips
{
	public class TooltipEditor : MonoBehaviour
	{
		private TooltipBlocker TooltipBlocker;
		public void TooltipEditorInitializer()
		{
			Get_TooltipBlocker();
		}
		public void Get_TooltipBlocker()
		{
			TooltipBlocker = new TooltipBlocker();
		}
	}
}