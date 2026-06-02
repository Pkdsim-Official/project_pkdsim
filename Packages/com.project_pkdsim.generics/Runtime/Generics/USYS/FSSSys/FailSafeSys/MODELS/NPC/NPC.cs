using project_pkdsim.Generics.NPC.Gender;
using project_pkdsim.Generics.NPC.Species;
using project_pkdsim.Generics.NPC.Trainer;

namespace project_pkdsim.Generics.USys.FSSys.FailSafeSys.Npc
{
    public interface INpc
    {
        public INpcSpecies NpcSpecies { get; }
        public INpcGender NpcGender { get; }
        public INpcTrainer NpcTrainer { get; }
    }
}