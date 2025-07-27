using project_pkdsim.Assets.USys.ITEMSSys.I.ID.ItemsScripts.Gifts.Bracelets;
using project_pkdsim.Assets.USys.ITEMSSys.I.ID.ItemsScripts.Gifts.Earrings;
using project_pkdsim.Assets.USys.ITEMSSys.I.ID.ItemsScripts.Gifts.Rings;
using project_pkdsim.Assets.USys.UItemsSystemSys.ID.ItemsScripts.Gifts.Necklaces;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.I
{
public class GiftsIDI : MonoBehaviour 
{
		private NecklacesGiftTypeID NecklacesID;
		private RIngsGiftTypeID RingsID;
		private EarringsGiftTypeID EarringsID;
		private BraceletsGiftTypeID BraceletsID;
		public void LoadNecklacesID()
		{
			NecklacesID.LoadNecklacesID();
		}
		public void LoadRingsID() 
		{
			RingsID.LoadRingsID();
		}
		public void LoadBraceletsID() 
		{
			BraceletsID.LoadBraceletsID();
		}
		public void LoadEarringsID() 
		{
			EarringsID.LoadEarringID();
		}
	}
}