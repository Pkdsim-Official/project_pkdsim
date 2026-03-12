using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.Base_Properties;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.Properties
{
	public class BraceletsPropertiesI : MonoBehaviour
	{
		private BraceletsLoveEffectPropertiesBase Base_Properties;
		public void Bracelets_LoadPropertiesBase(string value)
		{
			Base_Properties.LoadValues(value);
		}
	}
}