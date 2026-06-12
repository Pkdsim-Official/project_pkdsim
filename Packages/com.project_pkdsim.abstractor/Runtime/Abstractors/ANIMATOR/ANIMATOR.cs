using project_pkdsim.Generics.ANIMATOR;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.Abstractors.ANIMATOR
{
    public abstract class AbstractAnimator<TAnimator> where TAnimator : IAnimator
    {
        public abstract Animator GetAnimator(Animator animator);
        public abstract void PlayAnimation(string animationName);
        public abstract void StopAnimation(string animationName);
    }
}
