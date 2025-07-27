using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Steel.Beam_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Beam
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