using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Dad.Animator_I
{
	public class BraixenFailSafe : MonoBehaviour 
	{
		public Animator BraixenParentDad_Animator;
		public RuntimeAnimatorController someController;

		private BraixenParentDad_ConverterToAnimatorController BraixenParentDad_AnimatorCCA;
		private BraixenParentDad_AnimatorMovementController BraixenParentDad_AnimatorCMA;
		private BraixenParentDad_IdleAnimatorController BraixenParentDad_AnimatorICA;

		public void LoadFailSafeBraixenParentDad_AnimatorController()
		{
			LoadFailSafeBraixenParentDad_ConvertToAnimatorController();
			LoadFailSafeBraixenParentDad_MovementAnimatorController();
			LoadFailSafeBraixenParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeBraixenParentDad_ConvertToAnimatorController()
		{
			BraixenParentDad_AnimatorCCA.BR_ConverterToAnimatorController();
		}
		private void LoadFailSafeBraixenParentDad_MovementAnimatorController()
		{
			BraixenParentDad_AnimatorCMA.BRMovementAnimatorController();
		}
		private void LoadFailSafeBraixenParentDad_IdleAnimatorController()
		{
			BraixenParentDad_AnimatorICA.BR_IdleAnimatorController();
		}
	}
}