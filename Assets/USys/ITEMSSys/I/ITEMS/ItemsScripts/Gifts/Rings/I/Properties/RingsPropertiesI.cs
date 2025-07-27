using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Rings.I.Base_Properties;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Rings.I.Properties
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