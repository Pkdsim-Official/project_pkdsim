using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Bracelets;
using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Earrings;
using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces;
using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Rings;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.I
{
	public class GiftsI : MonoBehaviour
	{
		private NecklacesGiftType Necklaces;
		private EarringsGiftType Earrings;

		private BraceletsGiftType Bracelets;

		private RingsGiftType Rings;

		public GiftsI(NecklacesGiftType necklaces, EarringsGiftType earrings, BraceletsGiftType bracelets, RingsGiftType rings)
		{
			Necklaces = necklaces;
			Earrings = earrings;
			Bracelets = bracelets;
			Rings = rings;
		}

		public void LoadNecklaces(string value)
		{
			Necklaces.LoadNecklaces(value);
		}

		public void LoadEarrings(string value)
		{
			Earrings.LoadEarrings(value);
		}

		public void LoadBracelets(string value)
		{
			Bracelets.LoadBracelets(value);
		}

		public void LoadRings(string value)
		{
			Rings.LoadRings(value);
		}
	}
}