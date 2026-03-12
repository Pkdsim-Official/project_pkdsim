using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Rings.Modules.Base_Properties;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Rings.Modules.Properties
{
	public class RingsPropertiesI : MonoBehaviour
	{
		private RingsLoveEffectPropertiesBase Base_Properties;
		public void Rings_LoadPropertiesBase(string value)
		{
			Base_Properties.LoadValues(value);
		}
	}
}