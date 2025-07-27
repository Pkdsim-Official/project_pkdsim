using UnityEngine;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Earrings.I.Special_Effect
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
