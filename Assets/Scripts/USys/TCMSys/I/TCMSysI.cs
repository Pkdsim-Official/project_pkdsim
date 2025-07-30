using project_pkdsim.USys.TabChangeManagerSys;
using UnityEngine;

namespace project_pkdsim.USys.TCMSys.Modules
{
	public class TCMSysI : MonoBehaviour
	{
        private TabChangerSys TCMSys;
		public void Get_TCMSys() 
		{
			TCMSys.TCMSys_I();
		}
    }
}