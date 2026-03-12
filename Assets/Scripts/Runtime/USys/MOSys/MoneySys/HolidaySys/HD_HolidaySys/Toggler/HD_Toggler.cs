using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.Toggler.Asset;
using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.Toggler.Holiday;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.Toggler
{
	public class HD_toggler : MonoBehaviour
	{
		private HDHoliday_Toggler HDH_Toggler;
		private HDAsset_Toggler HDA_Toggler;

		protected void Get_HDH_Toggler()
		{
			HDH_Toggler = GetComponent<HDHoliday_Toggler>();
			HDH_Toggler.Toggler_Holiday();
		}
		protected void Get_HDA_Toggler()
		{
			HDA_Toggler = GetComponent<HDAsset_Toggler>();
			HDA_Toggler.Asset_Toggler();
		}
	}
}
