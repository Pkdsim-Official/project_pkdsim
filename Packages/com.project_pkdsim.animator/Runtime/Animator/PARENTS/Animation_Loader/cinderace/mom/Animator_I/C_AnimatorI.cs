using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.Mom.Animator_I
{
	public class CinderaceFailSafe : MonoBehaviour 
	{
		public Animator CinderaceParentMom_Animator;
		public RuntimeAnimatorController someController;

		private CinderaceParentMom_ConverterToAnimatorController CinderaceParentMom_AnimatorCCA;
		private CinderaceParentMom_AnimatorMovementController CinderaceParentMom_AnimatorCMA;
		private CinderaceParentMom_IdleAnimatorController CinderaceParentMom_AnimatorICA;


		public void LoadFailSafeCinderaceParentMom_AnimatorController()
		{
			LoadFailSafeCinderaceParentMom_ConvertToAnimatorController();
			LoadFailSafeCinderaceParentMom_MovementAnimatorController();
			LoadFailSafeCinderaceParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeCinderaceParentMom_ConvertToAnimatorController()
		{
			CinderaceParentMom_AnimatorCCA.C_ConverterToAnimatorController();
		}
		private void LoadFailSafeCinderaceParentMom_MovementAnimatorController()
		{
			CinderaceParentMom_AnimatorCMA.CMovementAnimatorController();
		}
		private void LoadFailSafeCinderaceParentMom_IdleAnimatorController()
		{
			CinderaceParentMom_AnimatorICA.C_IdleAnimatorController();
		}
	}
}