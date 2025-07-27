using UnityEngine;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Special_Effect
{
    public class Special_Effects : MonoBehaviour
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
