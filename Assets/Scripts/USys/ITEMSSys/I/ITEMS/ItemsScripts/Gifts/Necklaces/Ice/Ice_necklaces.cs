using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ice.Snowflake_necklace;
using UnityEngine;

namespace project_pkdsim.USys.ITEMSSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ice
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