using project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.PRICESys;
using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Bolt_necklace
{
    public class Bolt_NecklaceItemStock : MonoBehaviour
    {
        private PriceSys PriceSys;
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}