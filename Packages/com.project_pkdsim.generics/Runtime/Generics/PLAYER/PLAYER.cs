using project_pkdsim.Generics.PLAYER.Species;
using project_pkdsim.Generics.PLAYER.Trainer;
using project_pkdsim.Generics.PLAYER.Gender;

namespace project_pkdsim.Generics.PLAYER
{
    public interface IPlayer
    {
        public string Name { get; }
        public IPlayerTrainer playerTrainer { get; }
        public IPlayerGender playerGender { get; }
        public IPlayerSpecies playerSpecies { get; }
    }
}
