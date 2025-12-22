using project_pkdsim.USys.UnityPlayerSaveSys.FileSave;
using project_pkdsim.USys.UnityPlayerSaveSys.Save_Checker;

namespace project_pkdsim.USys.UnityPlayerSaveSys
{
	public class UnityPlayerSaveFIleSys
	{
		private UnityPlayerSaveFIle UnityPlayerSaveFIle;
		private PlayerDataSaveChecker PlayerDataSaveChecker;
		public void Get_UnityPlayerSaveFIle()
		{
			UnityPlayerSaveFIle.PlayerDataBuild();
		}
		public void Get_SaveChecker()
		{
            PlayerDataSaveChecker.RunDataSaveChecker();
        }
		public void UPSSys_I()
		{
			Get_UnityPlayerSaveFIle();
			Get_SaveChecker();
		}
	}
}
