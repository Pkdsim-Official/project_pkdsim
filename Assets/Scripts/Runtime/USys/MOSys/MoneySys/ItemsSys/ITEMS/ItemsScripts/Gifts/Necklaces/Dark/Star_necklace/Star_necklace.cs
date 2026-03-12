using System.Collections.Generic;
using UnityEngine;
using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.Base_Properties;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Dark.Star_necklace
{
    public class Star_NecklaceItem : MonoBehaviour
    {
        public List<Sys_Properties> SYS_properties { get; set; }

        public class Sys_Properties
        {
            public LoveEffectPropertiesBase SYS_properties { get; set; }
        }

        private class Star_Necklace_Item
        {
            public List<Sys_Properties> SYS_properties { get; set; }
        }
        public void GetBuilder()
        {
            
        }
    }
}
