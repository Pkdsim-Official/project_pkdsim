using project_pkdsim.Generics.ANIMATOR.Type.Model.Npc;
using project_pkdsim.Generics.ANIMATOR.Type.Model.Parent;

namespace project_pkdsim.Generics.ANIMATOR.Type.Model
{
    public interface IModelAnimator
    {
        public INpcModelAnimator animatorModel { get; }
        public IParentModelAnimator parentModelAnimator { get; }
    }
}