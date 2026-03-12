using UnityEngine;
using TMPro;
using System.IO;
using System.Text;
using System;
using Project_Pkdsim.Pkpedia.Npc.Database;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.Modules.TSys_DPk.Npc
{
    public class NpcTab : MonoBehaviour
    {
        public TMP_Text contentText; // Reference to the TextMeshPro UI element

        private PkpediaNpc_Database pkpNpcDatabase;

        private void Start()
        {
            if (pkpNpcDatabase == null)
            {
                Debug.LogError("PkpediaNpc_database component not found on GameObject.");
                return;
            }
            DisplayIntroduction(); // Display introduction on start
        }

        public void DisplayIntroduction()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Introduction());
        }

        public void DisplayVaporeon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Vaporeon());
        }

        public void DisplayFlareon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Flareon());
        }

        public void DisplayJolteon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Jolteon());
        }

        public void DisplayEspeon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Espeon());
        }

        public void DisplayUmbreon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Umbreon());
        }

        public void DisplayGlaceon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Glaceon());
        }

        public void DisplayLeafeon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Leafeon());
        }

        public void DisplaySylveon()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Sylveon());
        }

        public void DisplayAbsol()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Absol());
        }

        public void DisplayBeedrill()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Beedrill());
        }

        public void DisplayBlaziken()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Blaziken());
        }

        public void DisplayBraixen()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Braixen());
        }

        public void DisplayCinderace()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Cinderace());
        }

        public void DisplayDelphox()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Delphox());
        }

        public void DisplayDragapult()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Dragapult());
        }

        public void DisplayFrostlass()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Frostlass());
        }

        public void DisplayGarchomp()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Garchomp());
        }

        public void DisplayGardevoir()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Gardevoir());
        }

        public void DisplayLopunny()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Lopunny());
        }

        public void DisplayLucario()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Lucario());
        }

        public void DisplayLunala()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Lunala());
        }

        public void DisplayMeowscarada()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Meowscarada());
        }

        public void DisplayNoivern()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Noivern());
        }

        public void DisplayPheromosa()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Pheromosa());
        }

        public void DisplayPrimarina()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Primarina());
        }

        public void DisplaySalazzle()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Salazzle());
        }

        public void DisplayTsareena()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Tsareena());
        }

        public void DisplayZoroark()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Zoroark());
        }
        public void DisplayHatterene()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Hatterene());
        }

        public void DisplayVespiquen()
        {
            contentText.text = CaptureConsoleOutput(() => pkpNpcDatabase.Vespiquen());
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
            if (contentText != null && pkpNpcDatabase != null)
            {
                contentText.text = CaptureConsoleOutput(displayMethod);
            }
            else
            {
                Debug.LogError("contentText or pkpNpcDatabase is null.");
            }
        }
    }
}