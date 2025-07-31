#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace project_pkdsim.Editor.Workspaces.AtStartup.Tooltips.Blocker
{
	[InitializeOnLoad]
	public class TooltipBlocker
	{
		public void TooltipBlock()
		{
			EditorApplication.update += () =>
			{
				if (!string.IsNullOrEmpty(GUI.tooltip))
				{
					GUI.tooltip = "";
				}
			};
		}
		
		public void TooltipBlockerInitializer()
		{
			TooltipBlock();
		}
	}
}
#endif