using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ID.ItemsScripts.Gifts.Bracelets;
using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ID.ItemsScripts.Gifts.Earrings;
using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ID.ItemsScripts.Gifts.Rings;
using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ID.ItemsScripts.Gifts.Necklaces;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ID.ItemsScripts.Gifts.Modules
{
	public class GiftsIDI : MonoBehaviour 
	{
		private NecklacesGiftTypeID NecklacesID;
		private RingsGiftTypeID RingsID;
		private EarringsGiftTypeID EarringsID;
		private BraceletsGiftTypeID BraceletsID;
		public GiftsIDI(NecklacesGiftTypeID necklacesID, EarringsGiftTypeID earringsID, BraceletsGiftTypeID braceletsID, RingsGiftTypeID ringsID)
		{
			NecklacesID = necklacesID;
			EarringsID = earringsID;
			BraceletsID = braceletsID;
			RingsID = ringsID;
		}
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