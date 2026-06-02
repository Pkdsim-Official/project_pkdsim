using project_pkdsim.Generics.Parents.Gender;
using project_pkdsim.Generics.Parents.Species;

namespace  project_pkdsim.Generics.Parents
{
    public interface IParent
    {
        IParentGender ParentsGender { get; }
        IParentSpecies ParentsSpecies { get; }
    }
}