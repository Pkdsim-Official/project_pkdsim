using project_pkdsim.Assets.Editor.Workspaces.Namespace.Exporter;
using UnityEngine;

namespace project_pkdsim.Assets.Editor.Workspaces.Namespace
{
	public class Namespacer : MonoBehaviour 
	{
		private NamespaceExporter NamespaceExporter;
		public void NamespaceI() 
		{
			NamespaceExporter.OnGUI();
		}
	}
}