using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Mom.Animator_I
{
	public class FL_AnimatorI : MonoBehaviour 
	{
		public Animator FlareonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private FlareonParentMom_ConverterToAnimatorController FlareonParentMom_AnimatorCCA;
		private FlareonParentMom_AnimatorMovementController FlareonParentMom_AnimatorCMA;
		private FlareonParentMom_IdleAnimatorController FlareonParentMom_AnimatorICA;


		public void LoadFailSafeFlareonParentMom_AnimatorController()
		{
			LoadFailSafeFlareonParentMom_ConvertToAnimatorController();
			LoadFailSafeFlareonParentMom_MovementAnimatorController();
			LoadFailSafeFlareonParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeFlareonParentMom_ConvertToAnimatorController()
		{
			FlareonParentMom_AnimatorCCA.C_ConverterToAnimatorController();
		}
		private void LoadFailSafeFlareonParentMom_MovementAnimatorController()
		{
			FlareonParentMom_AnimatorCMA.CMovementAnimatorController();
		}
		private void LoadFailSafeFlareonParentMom_IdleAnimatorController()
		{
			FlareonParentMom_AnimatorICA.C_IdleAnimatorController();
		}
	}
}