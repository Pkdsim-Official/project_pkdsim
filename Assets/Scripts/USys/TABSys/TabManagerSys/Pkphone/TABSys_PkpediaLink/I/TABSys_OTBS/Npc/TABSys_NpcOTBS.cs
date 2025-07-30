using project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.Modules.TSys_DPk.Npc;
using UnityEngine;

namespace project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.Modules.TSys_OTBS.Npc
{
    public class NpcOTBS : MonoBehaviour
    {
        private int currentTabIndex = 0;

        private System.Action[] tabActions;

        private NpcTab TABSys_DNpcPk;

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
            NpcTab TSys_DNpcPk = Object.FindFirstObjectByType<NpcTab>();
            if (TSys_DNpcPk == null)
            {
                Debug.LogError("TABSys_DPK not found in the scene");
                return;
            }
            // Initialize the array with the methods corresponding to each tab
            tabActions = new System.Action[]
            {
                () => TSys_DNpcPk.DisplayAbsol(),
                () => TSys_DNpcPk.DisplayBeedrill(),
                () => TSys_DNpcPk.DisplayBlaziken(),
                () => TSys_DNpcPk.DisplayBraixen(),
                () => TSys_DNpcPk.DisplayCinderace(),
                () => TSys_DNpcPk.DisplayDelphox(),
                () => TSys_DNpcPk.DisplayDragapult(),
                () => TSys_DNpcPk.DisplayEspeon(),
                () => TSys_DNpcPk.DisplayFlareon(),
                () => TSys_DNpcPk.DisplayFrostlass(),
                () => TSys_DNpcPk.DisplayGarchomp(),
                () => TSys_DNpcPk.DisplayGardevoir(),
                () => TSys_DNpcPk.DisplayGlaceon(),
                () => TSys_DNpcPk.DisplayLeafeon(),
                () => TSys_DNpcPk.DisplayLopunny(),
                () => TSys_DNpcPk.DisplayLucario(),
                () => TSys_DNpcPk.DisplayLunala(),
                () => TSys_DNpcPk.DisplayMeowscarada(),
                () => TSys_DNpcPk.DisplayNoivern(),
                () => TSys_DNpcPk.DisplayPheromosa(),
                () => TSys_DNpcPk.DisplayPrimarina(),
                () => TSys_DNpcPk.DisplaySalazzle(),
                () => TSys_DNpcPk.DisplaySylveon(),
                () => TSys_DNpcPk.DisplayTsareena(),
                () => TSys_DNpcPk.DisplayUmbreon(),
                () => TSys_DNpcPk.DisplayVespiquen(),
                () => TSys_DNpcPk.DisplayZoroark(),
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
            if (TABSys_DNpcPk != null)
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