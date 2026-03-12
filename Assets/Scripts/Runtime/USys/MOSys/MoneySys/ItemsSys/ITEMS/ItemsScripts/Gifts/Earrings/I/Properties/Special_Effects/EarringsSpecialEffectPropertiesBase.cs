using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings.Modules.Special_Effect
{
    public class EarringsSpecialEffectsPropertiesBase : MonoBehaviour
    {
        private string specialEffect = "";

        public string GetSpecialEffect() => specialEffect;

        public void LoadSpecialEffectProperties(string value)
        {
            specialEffect = value + specialEffect;
            Debug.Log("SpecialEffect value updated to: " + specialEffect);
        }
    }
}
