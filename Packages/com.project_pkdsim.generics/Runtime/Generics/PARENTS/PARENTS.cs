using project_pkdsim.Generics.Parents.Type.Gender;
using project_pkdsim.Generics.Parents.Type.Species;

namespace  project_pkdsim.Generics.Parents
{
    public interface IPARENTS
    {
        ParentsGenderType ParentsType { get; }
        ParentsSpeciesType ParentsSpecies { get; }
    }
}