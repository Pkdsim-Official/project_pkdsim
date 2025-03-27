using System.Collections.Generic;
using UnityEngine;
using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Base_Properties;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Steel.Beam_necklace
{
    public class Beam_NecklaceItem : MonoBehaviour
    {
        public List<Sys_Properties> SYS_properties { get; set; }

        public class Sys_Properties
        {
            public LoveEffectPropertiesBase SYS_properties { get; set; }
        }
        private class Beam_Necklace_Item
        {
            public List<Sys_Properties> SYS_properties { get; set; }
        }
        public void GetBuilder()
        {
            
        }
    }
}