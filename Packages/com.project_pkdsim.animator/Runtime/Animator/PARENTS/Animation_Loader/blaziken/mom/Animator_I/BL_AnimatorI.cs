using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.Animator_I
{
	public class BlazikenFailSafe : MonoBehaviour 
	{
		public Animator BlazikenParentMom_Animator;
		public RuntimeAnimatorController someController;

		private BlazikenParentMom_ConverterToAnimatorController BlazikenParentMom_AnimatorCCA;
		private BlazikenParentMom_AnimatorMovementController BlazikenParentMom_AnimatorCMA;
		private BlazikenParentMom_IdleAnimatorController BlazikenParentMom_AnimatorICA;


		public void LoadFailSafeBlazikenParentMom_AnimatorController()
		{
			LoadFailSafeBlazikenParentMom_ConvertToAnimatorController();
			LoadFailSafeBlazikenParentMom_MovementAnimatorController();
			LoadFailSafeBlazikenParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeBlazikenParentMom_ConvertToAnimatorController()
		{
			BlazikenParentMom_AnimatorCCA.BL_ConverterToAnimatorController();
		}
		private void LoadFailSafeBlazikenParentMom_MovementAnimatorController()
		{
			BlazikenParentMom_AnimatorCMA.BLMovementAnimatorController();
		}
		private void LoadFailSafeBlazikenParentMom_IdleAnimatorController()
		{
			BlazikenParentMom_AnimatorICA.BL_IdleAnimatorController();
		}
	}
}