using Project_Pkdsim.USys.SceneManagerSys;
using UnityEngine;

namespace Project_Pkdsim.USys.SCMSys.Modules
{
	public class SCMSysI : MonoBehaviour
	{
		private UnitySceneManagerSys SCMSys;
		public void Get_SCMSys() 
		{
			SCMSys.SCMSys_I();
		}
    }
}