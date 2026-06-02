using project_pkdsim.Generics.Parents.Gender;
using project_pkdsim.Generics.Parents.Species;
using project_pkdsim.Generics.Parents.Trainer;

namespace project_pkdsim.Generics.USys.FSSys.FailSafeSys.Parents
{
    public interface IParents
    {
        public IParentSpecies parentSpecies { get; }
        public IParentGender parentGender { get; }
        public IParentTrainer parentTrainer { get; }
    }
}