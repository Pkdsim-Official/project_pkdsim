using project_pkdsim.USys.MoneySys.Modules;
using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules
{
	public class MOSysI : MonoBehaviour
	{
        private MoneySysI MoneySys;
		public void Get_MoneySys() 
		{
			MoneySys.MoneySys_I();
		}
    }
}