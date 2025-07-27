using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Bracelets.I.Base_Properties;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Bracelets.I.Properties
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