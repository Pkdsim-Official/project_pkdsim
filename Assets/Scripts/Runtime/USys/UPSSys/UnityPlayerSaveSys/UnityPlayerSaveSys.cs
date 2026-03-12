using Project_Pkdsim.USys.UnityPlayerSaveSys.FileSave;
using Project_Pkdsim.USys.UnityPlayerSaveSys.Save_Checker;

namespace Project_Pkdsim.USys.UnityPlayerSaveSys
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
