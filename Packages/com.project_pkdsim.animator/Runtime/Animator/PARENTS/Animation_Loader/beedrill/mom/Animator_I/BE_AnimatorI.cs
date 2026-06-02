using project_pkdsim.ANIMATOR.Parents.Beedrill.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.Mom.Animator_I
{
	public class BeedrillFailSafe : MonoBehaviour 
	{
		public Animator Beedrill_Animator;
		public RuntimeAnimatorController someController;

		private Beedrill_ConverterAnimatorController Beedrill_AnimatorCCA;
		private BeedrillParent_MovementAnimatorController Beedrill_AnimatorCMA;
		private Beedrill_IdleAnimatorController Beedrill_AnimatorICA;


		public void LoadFailSafeBeedrill_AnimatorController()
		{
			LoadFailSafeBeedrill_ConvertToAnimatorController();
			LoadFailSafeBeedrill_MovementAnimatorController();
			LoadFailSafeBeedrill_IdleAnimatorController();
		}
		private void LoadFailSafeBeedrill_ConvertToAnimatorController()
		{
			Beedrill_AnimatorCCA.BE_ConverterAnimatorController();
		}
		private void LoadFailSafeBeedrill_MovementAnimatorController()
		{
			Beedrill_AnimatorCMA.BE_MovementAnimatorController();
		}
		private void LoadFailSafeBeedrill_IdleAnimatorController()
		{
			Beedrill_AnimatorICA.BE_IdleAnimatorController();
		}
	}
}