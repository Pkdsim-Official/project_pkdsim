using Project_Pkdsim.USys.MoneySys.Modules.PRICESys;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.STOCKSys.ITEMS.ItemsScripts.Gifts.Necklaces.Spark_necklace
{
    public class Spark_NecklaceItemStock : MonoBehaviour
    {
        private PriceSys PriceSys;        
        public void GetPriceSys() 
        {
            PriceSys.LoadPriceSys();
        }
    }
}