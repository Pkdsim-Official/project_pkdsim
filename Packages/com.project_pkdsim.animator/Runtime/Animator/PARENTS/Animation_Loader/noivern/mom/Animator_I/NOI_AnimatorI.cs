using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Mom.Animator_I
{	public class NoivernFailSafe : MonoBehaviour 
	{
		public Animator NoivernParentMom_Animator;
		public RuntimeAnimatorController someController;
		private NoivernParentMom_ConverterToAnimatorController NoivernParentMom_AnimatorCCA;
		private NoivernParentMom_AnimatorMovementController NoivernParentMom_AnimatorCMA;
		private NoivernParentMom_IdleAnimatorController NoivernParentMom_AnimatorICA;

		public void LoadFailSafeNoivernParentMom_AnimatorController()
		{
			LoadFailSafeNoivernParentMom_ConvertToAnimatorController();
			LoadFailSafeNoivernParentMom_MovementAnimatorController();
			LoadFailSafeNoivernParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeNoivernParentMom_ConvertToAnimatorController()
		{
			NoivernParentMom_AnimatorCCA.NOI_ConverterToAnimatorController();
		}
		private void LoadFailSafeNoivernParentMom_MovementAnimatorController()
		{
			NoivernParentMom_AnimatorCMA.NOIMovementAnimatorController();
		}
		private void LoadFailSafeNoivernParentMom_IdleAnimatorController()
		{
			NoivernParentMom_AnimatorICA.NOI_IdleAnimatorController();
		}
	}
}