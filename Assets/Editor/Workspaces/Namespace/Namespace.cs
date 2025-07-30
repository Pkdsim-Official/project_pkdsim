using project_pkdsim.Editor.Workspaces.Namespace.Exporter;
using UnityEngine;

namespace project_pkdsim.Editor.Workspaces.Namespace
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