using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Ice.Snowflake_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Ice
{
	public class Ice_Necklaces : MonoBehaviour
	{
		private Snowflake_NecklaceItem Snowflake_NecklaceItem;

		public void Get_SnowflakeNecklace()
		{
			Snowflake_NecklaceItem.GetBuilder();
		}
	}
}