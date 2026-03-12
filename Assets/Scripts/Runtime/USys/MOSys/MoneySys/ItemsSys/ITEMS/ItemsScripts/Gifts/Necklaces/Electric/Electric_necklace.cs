using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Electric.Bolt_necklace;
using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Electric.Spark_necklace;
using UnityEngine;

namespace Project_Pkdsim.USysUnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Electric
{
	public class Electric_Necklace : MonoBehaviour
	{
		private Bolt_NecklaceItem Bolt_NecklaceItem;
		private Spark_NecklaceItem Spark_NecklaceItem;

		public void Get_BoltNecklace()
		{
			Bolt_NecklaceItem.GetBuilder();
		}
		public void Get_SparkNecklace()
		{
			Spark_NecklaceItem.GetBuilder();
		}
	}
}