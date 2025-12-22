using project_pkdsim.USys.UnityPlayerSaveSys;
using UnityEngine;

namespace project_pkdsim.USys.UPSSys.Modules
{
	public class UPSSysI : MonoBehaviour 
	{
        private UnityPlayerSaveFIleSys UnityPlayerSaveSys;
		public void Get_UnityPlayerSaveSys() 
		{
			UnityPlayerSaveSys.UPSSys_I();
		}
    }
}