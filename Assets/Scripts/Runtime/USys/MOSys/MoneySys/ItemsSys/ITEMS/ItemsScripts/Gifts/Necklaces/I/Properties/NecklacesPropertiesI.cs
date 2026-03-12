using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.Base_Properties;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.Properties
{
	public class NecklacesPropertiesI : MonoBehaviour
	{
		private LoveEffectPropertiesBase Base_Properties;
		public void Necklaces_LoadPropertiesBase(string value)
		{
			Base_Properties.LoadValues(value);
		}
	}
}