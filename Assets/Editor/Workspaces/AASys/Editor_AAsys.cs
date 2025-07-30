using project_pkdsim.Editor.Workspaces.AASys.I;

namespace project_pkdsim.Editor.Workspaces
{
	public class Editor_AAsys : Editor_AASysI 
	{
		private void AASys_Initializer()
		{
			AASys_Init();
		}
		public void Editor_AAsysI() 
		{
			AASys_Initializer();
		}
	}
}