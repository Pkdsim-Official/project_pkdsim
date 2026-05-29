using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Mom.Animator_I
{
	public class BraixenFailSafe : MonoBehaviour 
	{
		public Animator BraixenParentMom_Animator;
		public RuntimeAnimatorController someController;

		private BraixenParentMom_ConverterToAnimatorController BraixenParentMom_AnimatorCCA;
		private BraixenParentMom_AnimatorMovementController BraixenParentMom_AnimatorCMA;
		private BraixenParentMom_IdleAnimatorController BraixenParentMom_AnimatorICA;

		public void LoadFailSafeBraixenParentMom_AnimatorController()
		{
			LoadFailSafeBraixenParentMom_ConvertToAnimatorController();
			LoadFailSafeBraixenParentMom_MovementAnimatorController();
			LoadFailSafeBraixenParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeBraixenParentMom_ConvertToAnimatorController()
		{
			BraixenParentMom_AnimatorCCA.BR_ConverterToAnimatorController();
		}
		private void LoadFailSafeBraixenParentMom_MovementAnimatorController()
		{
			BraixenParentMom_AnimatorCMA.BRMovementAnimatorController();
		}
		private void LoadFailSafeBraixenParentMom_IdleAnimatorController()
		{
			BraixenParentMom_AnimatorICA.BR_IdleAnimatorController();
		}
	}
}