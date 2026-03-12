using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Absol;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Beedrill;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Blaziken;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Braixen;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Cinderace;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Delphox;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Espeon;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Flareon;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Glaceon;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Garchomp;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Gardevoir;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Hatterene;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Jolteon;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Lopunny;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Leafeon;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Lucario;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Lunala;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Meowscarada;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Noivern;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Pheromosa;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Primarina;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Salazzle;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Sylveon;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Tsareena;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Umbreon;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Vaporeon;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Vespiquen;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Zoroark;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Dragapult;
using Project_Pkdsim.Pkpedia.Npc.Database.Modules.Frostlass;
using System;
using UnityEngine;

namespace Project_Pkdsim.Pkpedia.Npc.Database
{
    public class PkpediaNpc_Database : MonoBehaviour
    {

        public VaporeonDex VaporeonDex;
        public FlareonDex FlareonDex;
        public JolteonDex JolteonDex;
        public UmbreonDex UmbreonDex;
        public EspeonDex EspeonDex;
        public LeafeonDex LeafeonDex;
        public GlaceonDex GlaceonDex;
        public SylveonDex SylveonDex;
        public TsareenaDex TsareenaDex;
        public GardevoirDex GardevoirDex;
        public LopunnyDex LopunnyDex;
        public LunalaDex LunalaDex;
        public BraixenDex BraixenDex;
        public DragapultDex DragapultDex;
        public LucarioDex LucarioDex;
        public GarchompDex GarchompDex;
        public AbsolDex AbsolDex;
        public BeedrillDex BeedrillDex;
        public BlazikenDex BlazikenDex;
        public CinderaceDex CinderaceDex;
        public FrostlassDex FrostlassDex;
        public HattereneDex HattereneDex;
        public MeowscaradaDex MeowscaradaDex;
        public ZoroarkDex ZoroarkDex;
        public VespiquenDex VespiquenDex;
        public PrimarinaDex PrimarinaDex;
        public NoivernDex NoivernDex;
        public PheromosaDex PheromosaDex;
        public DelphoxDex DelphoxDex;
        public SalazzleDex SalazzleDex;

        public void Vaporeon()
        {
            VaporeonDex.Pkpedia_link();
        }

        public void Flareon()
        {
            FlareonDex.Pkpedia_link();
        }

        public void Jolteon()
        {
            JolteonDex.Pkpedia_link();
        }

        public void Umbreon()
        {
            UmbreonDex.Pkpedia_link();
        }

        public void Espeon()
        {
            EspeonDex.Pkpedia_link();
        }

        public void Leafeon()
        {
            LeafeonDex.Pkpedia_link();
        }

        public void Glaceon()
        {
            GlaceonDex.Pkpedia_link();
        }

        public void Sylveon()
        {
            SylveonDex.Pkpedia_link();
        }

        public void Tsareena()
        {
            TsareenaDex.Pkpedia_link();
        }

        public void Gardevoir()
        {
            GardevoirDex.Pkpedia_link();
        }

        public void Lopunny()
        {
            LopunnyDex.Pkpedia_link();
        }

        public void Lunala()
        {
            LunalaDex.Pkpedia_link();
        }

        public void Braixen()
        {
            BraixenDex.Pkpedia_link();
        }

        public void Dragapult()
        {
            DragapultDex.Pkpedia_link();
        }

        public void Lucario()
        {
            LucarioDex.Pkpedia_link();
        }

        public void Garchomp()
        {
            GarchompDex.Pkpedia_link();
        }

        public void Absol()
        {
            AbsolDex.Pkpedia_link();
        }

        public void Beedrill()
        {
            BeedrillDex.Pkpedia_link();
        }

        public void Blaziken()
        {
            BlazikenDex.Pkpedia_link();
        }

        public void Cinderace()
        {
            CinderaceDex.Pkpedia_link();
        }

        public void Frostlass()
        {
            FrostlassDex.Pkpedia_link();
        }
        
        public void Hatterene()
        {
            HattereneDex.Pkpedia_link();
        }
        
        public void Meowscarada()
        {
            MeowscaradaDex.Pkpedia_link();
        }
        
        public void Zoroark()
        {
            ZoroarkDex.Pkpedia_link();
        }
        
        public void Vespiquen()
        {
            VespiquenDex.Pkpedia_link();
        }

        public void Primarina()
        {
            PrimarinaDex.Pkpedia_link();
        }

        public void Noivern()
        {
            NoivernDex.Pkpedia_link();
        }

        public void Pheromosa()
        {
            PheromosaDex.Pkpedia_link();
        }

        public void Delphox()
        {
            DelphoxDex.Pkpedia_link(); 
        }

        public void Salazzle()
        {
            SalazzleDex.Pkpedia_link();
        }

        public void Introduction()
        {
            Console.WriteLine("Introduction to Pkpedia Database: Welcome to the Pkpedia Database! In this collection, we have gathered information about some fascinating Pokémon and their unique traits. Each entry provides insight into the Pokémon's personality, parental relationships, gender, and backstory. Get ready to explore and learn more about these incredible creatures!");
        }
    }
}