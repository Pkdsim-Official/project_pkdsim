using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Normal.Cat_necklace;
using UnityEngine;

namespace Project_Pkdsim.USysUnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Normal
{
	public class Normal_Necklaces : MonoBehaviour
	{
		private Cat_NecklaceItem Cat_NecklaceItem;

		public void Get_CatNecklace()
		{
			Cat_NecklaceItem.GetBuilder();
		}
	}
}