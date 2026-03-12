using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings.Modules.Base_Properties;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings.Modules.Properties
{
	public class EarringsPropertiesI : MonoBehaviour
	{
		private EarringsLoveEffectPropertiesBase Base_Properties;
		public void Earrings_LoadPropertiesBase(string value)
		{
			Base_Properties.LoadValues(value);
		}
	}
}