using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Earrings.I.Base_Properties;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Earrings.I.Properties
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