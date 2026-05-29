using project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.PRICESys;
using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Hypno_necklace
{
    public class Hypno_NecklaceItemStock : MonoBehaviour
    {

        private PriceSys PriceSys;        
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}