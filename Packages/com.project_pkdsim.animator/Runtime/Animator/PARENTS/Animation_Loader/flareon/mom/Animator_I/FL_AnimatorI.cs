using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Mom.Animator_I
{
	public class FLParentMom_AnimatorI : MonoBehaviour 
	{
		public Animator FlareonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private FlareonParentMom_ConverterAnimatorController FlareonParentMom_AnimatorCCA;
		private FlareonParentMom_MovementAnimatorController FlareonParentMom_AnimatorCMA;
		private FlareonParentMom_IdleAnimatorController FlareonParentMom_AnimatorICA;

		public void LoadFailSafeFlareonParentMom_AnimatorController()
		{
			LoadFailSafeFlareonParentMom_ConvertToAnimatorController();
			LoadFailSafeFlareonParentMom_MovementAnimatorController();
			LoadFailSafeFlareonParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeFlareonParentMom_ConvertToAnimatorController()
		{
			FlareonParentMom_AnimatorCCA.FLParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeFlareonParentMom_MovementAnimatorController()
		{
			FlareonParentMom_AnimatorCMA.FLParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeFlareonParentMom_IdleAnimatorController()
		{
			FlareonParentMom_AnimatorICA.FLParentMom_IdleAnimatorController();
		}
	}
}