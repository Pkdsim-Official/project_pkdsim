using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Bolt_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Crust_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.PunchingBag_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Brick_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Cat_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Heart_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Beam_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Leaf_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Lunar_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Sun_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.WaterDrop_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Butterfly_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Wings_necklace;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson
{
	public class LoadNecklacesJson : MonoBehaviour
	{
		private Beam_necklaceJsonLoader Beam_necklace;

		private Bolt_necklaceJsonLoader Bolt_necklace;

		private Brick_necklaceJsonLoader Brick_necklace;

		private Cat_necklaceJsonLoader Cat_necklace;

		private Crust_necklaceJsonLoader Crust_necklace;

		private Heart_necklaceJsonLoader Heart_necklace;

		private Leaf_necklaceJsonLoader Leaf_necklace;

		private Lunar_necklaceJsonLoader Lunar_necklace;

		private PunchingBag_NecklaceJsonLoader PunchingBag_necklace;

		private Sun_necklaceJsonLoader Sun_necklace;

		private WaterDroplet_necklaceJsonLoader WaterDroplet_necklace;

		private Butterfly_necklaceJsonLoader Butterfly_necklace;

		private Wings_necklaceJsonLoader Wings_necklace;

		public void LoadNecklacesJsons()
		{
			Beam_necklace.BeamNecklace_LoveSys_Stager();
			Bolt_necklace.BoltNecklace_LoveSys_Stager();
			Brick_necklace.BrickNecklace_LoveSys_Stager();
			Cat_necklace.CatNecklace_LoveSys_Stager();
			Crust_necklace.CrustNecklace_LoveSys_Stager();
			Heart_necklace.HeartNecklace_LoveSys_Stager();
			Leaf_necklace.LeafNecklace_LoveSys_Stager();
			Lunar_necklace.LunarNecklace_LoveSys_Stager();
			PunchingBag_necklace.PunchingBagNecklace_LoveSys_Stager();
			Sun_necklace.SunNecklace_LoveSys_Stager();
			WaterDroplet_necklace.WaterDropletNecklace_LoveSys_Stager();
			Butterfly_necklace.ButterflyNecklace_LoveSys_Stager();
			Wings_necklace.WingsNecklace_LoveSys_Stager();
		}
	}
}