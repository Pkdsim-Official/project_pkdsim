using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Dad.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Beedrill.Dad.Animator_I
{
	public class LFS_BeedrillFailSafe : MonoBehaviour 
	{
		public Animator BeedrillParentDad_Animator;
		public RuntimeAnimatorController someController;

		private BeedrillParentDad_ConverterAnimatorController LFSBeedrill_AnimatorCCA;
		private BeedrillParentDad_MovementAnimatorController LFSBeedrill_AnimatorCMA;
		private BeedrillParentDad_IdleAnimatorController LFSBeedrill_AnimatorICA;


		public void LoadFailSafeBeedrill_AnimatorController()
		{
			LoadFailSafeBeedrill_ConvertToAnimatorController();
			LoadFailSafeBeedrill_MovementAnimatorController();
			LoadFailSafeBeedrill_IdleAnimatorController();
		}
		private void LoadFailSafeBeedrill_ConvertToAnimatorController()
		{
			LFSBeedrill_AnimatorCCA.BEParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeBeedrill_MovementAnimatorController()
		{
			LFSBeedrill_AnimatorCMA.BE_MovementAnimatorController();
		}
		private void LoadFailSafeBeedrill_IdleAnimatorController()
		{
			LFSBeedrill_AnimatorICA.BEParentDad_IdleAnimatorController();
		}
	}
}