using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Steel.Beam_necklace;
using UnityEngine;

namespace Project_Pkdsim.USysUnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Beam
{
	public class Steel_Necklace : MonoBehaviour
	{
		private Beam_NecklaceItem Beam_NecklaceItem;

		public void Get_BeamNecklace()
		{
			Beam_NecklaceItem.GetBuilder();
		}
	}
}