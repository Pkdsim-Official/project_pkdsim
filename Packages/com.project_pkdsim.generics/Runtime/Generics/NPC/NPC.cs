using project_pkdsim.Generics.NPC.Species.Type;

namespace project_pkdsim.Generics.NPC
{
    public interface INpc
    {
        string Name { get; }
        void Interact();
        SpeciesType Species { get; }
    }
}
