using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_StoreLink.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_StoreLink
{
	public class TABSys_StoreLinker : MonoBehaviour 
	{
		private TABSys_StoreLINK TABSys_StoreLinkI;
		
		public void TABSys_storeLink() 
		{
			TABSys_StoreLinkI.TABSys_StoreMenuI();
		}
	}
}