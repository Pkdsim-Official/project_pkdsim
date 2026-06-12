using project_pkdsim.Generics.ANIMATOR;
using project_pkdsim.Generics.ANIMATOR.Type.Model;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.Abstractors.ANIMATOR.Model
{
    public abstract class AbstractModelAnimator<TModelAnimator> where TModelAnimator : IModelAnimator
    {
        public abstract Animator Animator { get; }
		public abstract RuntimeAnimatorController someController { get; }
		public abstract NPCSpeciesType SpeciesType { get; }
        public abstract Animator GetAnimator(Animator animator);
        public abstract void PlayAnimation(string animationName);
        public abstract void StopAnimation(string animationName);
    }
}
