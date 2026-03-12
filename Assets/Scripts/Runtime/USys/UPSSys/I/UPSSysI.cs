using Project_Pkdsim.USys.UnityPlayerSaveSys;
using UnityEngine;

namespace Project_Pkdsim.USys.UPSSys.Modules
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