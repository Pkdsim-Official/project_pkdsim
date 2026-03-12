using Project_Pkdsim.USys.MoneySys.UnityItemSys.Chance.Daily.Modules.I_Data.Randomizer;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Chance.Daily.Modules.I_Data
{
	public class ItemsChanceDaily_I_Data : MonoBehaviour 
	{
		private ItemsChanceDaily_Randomizer ItemsChanceDaily_Randomizer;
		private void ItemsChanceDailyRandomizer()
		{
			ItemsChanceDaily_Randomizer.ItemsChanceDailyRandomizer();
		}
		public void ITEMSChanceDaily_I_Data()
		{
			ItemsChanceDailyRandomizer();
		}
	}
}