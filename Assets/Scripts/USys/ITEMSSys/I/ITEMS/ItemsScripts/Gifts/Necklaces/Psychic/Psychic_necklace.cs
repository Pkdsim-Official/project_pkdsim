using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Psychic.Hypno_necklace;
using UnityEngine;

namespace project_pkdsim.USys.ITEMSSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Psychic
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