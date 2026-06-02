using project_pkdsim.Generics.PLAYER.Gender;
using project_pkdsim.Generics.PLAYER.Species;
using project_pkdsim.Generics.PLAYER.Trainer;

namespace project_pkdsim.Generics.USys.FSSys.FailSafeSys.Player
{
    public interface IPlayer
    {
        public IPlayerSpecies PlayerSpecies { get; }
        public IPlayerGender PlayerGender { get; }
        public IPlayerTrainer PlayerTrainer { get; }
    }
}