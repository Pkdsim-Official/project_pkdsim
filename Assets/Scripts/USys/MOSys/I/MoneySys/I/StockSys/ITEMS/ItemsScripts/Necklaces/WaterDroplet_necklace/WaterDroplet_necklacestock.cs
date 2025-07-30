using project_pkdsim.USys.MoneySys.Modules.PRICESys;
using UnityEngine;

namespace project_pkdsim.USys.MoneySys.Modules.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.WaterDroplet_necklace
{
    public class WaterDroplet_NecklaceItemStock : MonoBehaviour
    {
        private PriceSys PriceSys;
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}