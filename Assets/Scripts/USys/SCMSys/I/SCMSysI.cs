using project_pkdsim.USys.SceneManagerSys;
using UnityEngine;

namespace project_pkdsim.USys.SCMSys.Modules
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