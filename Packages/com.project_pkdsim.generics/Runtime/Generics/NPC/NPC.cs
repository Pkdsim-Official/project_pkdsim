using project_pkdsim.Generics.NPC.Gender;
using project_pkdsim.Generics.NPC.Species;
using project_pkdsim.Generics.NPC.Trainer;

namespace project_pkdsim.Generics.NPC
{
    public interface INpc
    {
        public string Name { get; }
        public INpcSpecies Species { get; }
        public INpcGender Gender { get; }
        public INpcTrainer Trainer { get; }
    }
}
