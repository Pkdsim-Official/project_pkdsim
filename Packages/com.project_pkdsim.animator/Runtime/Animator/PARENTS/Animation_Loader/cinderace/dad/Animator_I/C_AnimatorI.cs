using project_pkdsim.ANIMATOR.Parents.Cinderace.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Cinderace.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Cinderace.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.Animator_I
{
	public class CinderaceFailSafe : MonoBehaviour 
	{
		public Animator CinderaceParentDad_Animator;
		public RuntimeAnimatorController someController;

		private CinderaceParentDad_ConverterToAnimatorController CinderaceParentDad_AnimatorCCA;
		private CinderaceParentDad_AnimatorMovementController CinderaceParentDad_AnimatorCMA;
		private CinderaceParentDad_IdleAnimatorController CinderaceParentDad_AnimatorICA;


		public void LoadFailSafeCinderaceParentDad_AnimatorController()
		{
			LoadFailSafeCinderaceParentDad_ConvertToAnimatorController();
			LoadFailSafeCinderaceParentDad_MovementAnimatorController();
			LoadFailSafeCinderaceParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeCinderaceParentDad_ConvertToAnimatorController()
		{
			CinderaceParentDad_AnimatorCCA.C_ConverterToAnimatorController();
		}
		private void LoadFailSafeCinderaceParentDad_MovementAnimatorController()
		{
			CinderaceParentDad_AnimatorCMA.CMovementAnimatorController();
		}
		private void LoadFailSafeCinderaceParentDad_IdleAnimatorController()
		{
			CinderaceParentDad_AnimatorICA.C_IdleAnimatorController();
		}
	}
}