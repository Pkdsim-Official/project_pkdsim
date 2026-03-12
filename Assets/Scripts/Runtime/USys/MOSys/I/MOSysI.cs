using Project_Pkdsim.USys.MoneySys.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MOSys.Modules
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