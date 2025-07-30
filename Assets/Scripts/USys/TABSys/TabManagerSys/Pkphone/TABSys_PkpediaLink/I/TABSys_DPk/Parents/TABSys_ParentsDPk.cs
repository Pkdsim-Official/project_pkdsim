using UnityEngine;
using TMPro;
using System.IO;
using System.Text;
using System;
using project_pkdsim.Pkpedia.Parents.Database;

namespace project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.Modules.TSys_DPk.Parents
{
    public class ParentsTab : MonoBehaviour
    {
        public TMP_Text contentText; // Reference to the TextMeshPro UI element

        private PkpediaParents_Database pkpParentsDatabase;

        private void Start()
        {
            if (pkpParentsDatabase == null)
            {
                Debug.LogError("PkpediaNpc_database component not found on GameObject.");
                return;
            }
            DisplayIntroduction(); // Display introduction on start
        }

        public void DisplayIntroduction()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Introduction());
        }

        public void DisplayVaporeon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Vaporeon());
        }

        public void DisplayFlareon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Flareon());
        }

        public void DisplayJolteon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Jolteon());
        }

        public void DisplayEspeon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Espeon());
        }

        public void DisplayUmbreon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Umbreon());
        }

        public void DisplayGlaceon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Glaceon());
        }

        public void DisplayLeafeon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Leafeon());
        }

        public void DisplaySylveon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Sylveon());
        }

        public void DisplayAbsol()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Absol());
        }

        public void DisplayBeedrill()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Beedrill());
        }

        public void DisplayBlaziken()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Blaziken());
        }

        public void DisplayBraixen()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Braixen());
        }

        public void DisplayCinderace()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Cinderace());
        }

        public void DisplayDelphox()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Delphox());
        }

        public void DisplayDragapult()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Dragapult());
        }

        public void DisplayFrostlass()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Frostlass());
        }

        public void DisplayGarchomp()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Garchomp());
        }

        public void DisplayGardevoir()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Gardevoir());
        }

        public void DisplayLopunny()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Lopunny());
        }

        public void DisplayLucario()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Lucario());
        }

        public void DisplayLunala()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Lunala());
        }

        public void DisplayMeowscarada()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Meowscarada());
        }

        public void DisplayNoivern()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Noivern());
        }

        public void DisplayPheromosa()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Pheromosa());
        }

        public void DisplayPrimarina()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Primarina());
        }

        public void DisplaySalazzle()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Salazzle());
        }

        public void DisplayTsareena()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Tsareena());
        }

        public void DisplayZoroark()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Zoroark());
        }
        public void DisplayHatterene()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Hatterene());
        }

        public void DisplayVespiquen()
        {
            contentText.text = CaptureConsoleOutput(() => pkpParentsDatabase.Vespiquen());
        }

        private string CaptureConsoleOutput(Action action)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            TextWriter originalOut = Console.Out;
            Console.SetOut(sw);
            action();
            Console.SetOut(originalOut);
            return sb.ToString();
        }
        public void DisplayPokemon(Action displayMethod)
        {
            if (contentText != null && pkpParentsDatabase != null)
            {
                contentText.text = CaptureConsoleOutput(displayMethod);
            }
            else
            {
                Debug.LogError("contentText or pkpParentsDatabase is null.");
            }
        }
    }
}