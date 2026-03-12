using Project_Pkdsim.USys.MoneySys.Modules.PRICESys;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Leaf_necklace
{
    public class Leaf_NecklaceItemStock : MonoBehaviour
    {
        private PriceSys PriceSys;
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}