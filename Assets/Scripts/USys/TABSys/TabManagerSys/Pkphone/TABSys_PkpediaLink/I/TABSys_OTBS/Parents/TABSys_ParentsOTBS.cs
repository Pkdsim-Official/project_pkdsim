using project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.Modules.TSys_DPk;
using project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.Modules.TSys_DPk.Parents;
using UnityEngine;

namespace project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.Modules.TSys_OTBS.Parents
{
    public class ParentsOTBS : MonoBehaviour
    {
        private int currentTabIndex = 0;
        private System.Action[] tabActions;
        private ParentsTab TSys_DParentsPk;

        /// <summary>
        /// Called when the object is initialized.
        /// </summary>
        /// <remarks>
        /// Finds the TABSys_DPK object in the scene and initializes
        /// the tabActions array with the methods corresponding to each tab.
        /// Displays the first tab (Introduction) on start.
        /// </remarks>
        public void Start()
        {
            ParentsTab TSys_DParentsPk = Object.FindFirstObjectByType<ParentsTab>();
            if (TSys_DParentsPk == null)
            {
                Debug.LogError("TABSys_DPK not found in the scene");
                return;
            }
            // Initialize the array with the methods corresponding to each tab
            tabActions = new System.Action[]
            {
                () => TSys_DParentsPk.DisplayAbsol(),
                () => TSys_DParentsPk.DisplayBeedrill(),
                () => TSys_DParentsPk.DisplayBlaziken(),
                () => TSys_DParentsPk.DisplayBraixen(),
                () => TSys_DParentsPk.DisplayCinderace(),
                () => TSys_DParentsPk.DisplayDelphox(),
                () => TSys_DParentsPk.DisplayDragapult(),
                () => TSys_DParentsPk.DisplayEspeon(),
                () => TSys_DParentsPk.DisplayFlareon(),
                () => TSys_DParentsPk.DisplayFrostlass(),
                () => TSys_DParentsPk.DisplayGarchomp(),
                () => TSys_DParentsPk.DisplayGardevoir(),
                () => TSys_DParentsPk.DisplayGlaceon(),
                () => TSys_DParentsPk.DisplayLeafeon(),
                () => TSys_DParentsPk.DisplayLopunny(),
                () => TSys_DParentsPk.DisplayLucario(),
                () => TSys_DParentsPk.DisplayLunala(),
                () => TSys_DParentsPk.DisplayMeowscarada(),
                () => TSys_DParentsPk.DisplayNoivern(),
                () => TSys_DParentsPk.DisplayPheromosa(),
                () => TSys_DParentsPk.DisplayPrimarina(),
                () => TSys_DParentsPk.DisplaySalazzle(),
                () => TSys_DParentsPk.DisplaySylveon(),
                () => TSys_DParentsPk.DisplayTsareena(),
                () => TSys_DParentsPk.DisplayUmbreon(),
                () => TSys_DParentsPk.DisplayVespiquen(),
                () => TSys_DParentsPk.DisplayZoroark(),
                // Add more as needed
            };
            // Display the first tab (Introduction) on start
            DisplayCurrentTab();
        }

        public void NextTab()
        {
            if (currentTabIndex < tabActions.Length - 1)
            {
                currentTabIndex++;
                DisplayCurrentTab();
            }
            else
            {
                Debug.Log("You are on the last tab.");
            }
        }

        public void PreviousTab()
        {
            if (currentTabIndex > 0)
            {
                currentTabIndex--;
                DisplayCurrentTab();
            }
            else
            {
                Debug.Log("You are on the first tab.");
            }
        }

        public void DisplayCurrentTab()
        {
            DisplayPokemon(tabActions[currentTabIndex]);
        }

        public void DisplayPokemon(System.Action displayMethod)
        {
            if (TSys_DParentsPk != null)
            {
                displayMethod.Invoke();
            }
            else
            {
                Debug.LogWarning("TABSys_OTBS is not initialized");
            }
        }
    }
}
