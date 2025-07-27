using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Psychic.Hypno_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Psychic
{
	public class Psychic_necklace : MonoBehaviour
	{
		private Hypno_NecklaceItem Hypno_NecklaceItem;

		public void Get_HypnoNecklace()
		{
			Hypno_NecklaceItem.GetBuilder();
		}
	}
}