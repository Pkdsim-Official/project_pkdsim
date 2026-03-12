using Project_Pkdsim.USys.TabChangeManagerSys;
using UnityEngine;

namespace Project_Pkdsim.USys.TCMSys.Modules
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