using project_pkdsim.Generics.ANIMATOR.Type.Model;
using project_pkdsim.Generics.ANIMATOR.Type.General;

namespace project_pkdsim.Generics.ANIMATOR
{
    public interface IAnimator
    {
        public IModelAnimator modelAnimator { get; }
        public IGeneralAnimator generalAnimator { get; }
    }

    public interface IModelAnimators
    {
        public abstract IModelAnimator animatorModel { get; }
    }

    public interface IGeneralAnimators
    {
        public abstract IGeneralAnimator animatorGeneral { get; }
    }
}