using project_pkdsim.Generics.NPC.Species;

namespace project_pkdsim.Generics.NPC
{
    public interface INpc
    {
        string Name { get; }
        void Interact();
        ISpecies Species { get; }
    }
}
