using System.Collections.Generic;
using UnityEngine;
using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.Base_Properties;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ghost.Soul_necklace
{
    public class Soul_NecklaceItem : MonoBehaviour
    {
        public List<Sys_Properties> SYS_properties { get; set; }

        public class Sys_Properties
        {
            public LoveEffectPropertiesBase SYS_properties { get; set; }
        }

        private class Soul_Necklace_Item
        {
            public List<Sys_Properties> SYS_properties { get; set; }
        }
        public void GetBuilder()
        {
            
        }
    }
}