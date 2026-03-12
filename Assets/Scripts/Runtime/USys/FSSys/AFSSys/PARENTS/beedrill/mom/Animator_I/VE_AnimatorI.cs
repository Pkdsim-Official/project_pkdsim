using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.Animator_I
{
	public class LFS_BeedrillFailSafe : MonoBehaviour 
	{
		public Animator BeedrillParentMom_Animator;
		public RuntimeAnimatorController someController;

		private BeedrillParentMom_ConverterAnimatorController LFSBeedrill_AnimatorCCA;
		private BeedrillParentMom_MovementAnimatorController LFSBeedrill_AnimatorCMA;
		private BeedrillParentMom_IdleAnimatorController LFSBeedrill_AnimatorICA;


		public void LoadFailSafeBeedrill_AnimatorController()
		{
			LoadFailSafeBeedrill_ConvertToAnimatorController();
			LoadFailSafeBeedrill_MovementAnimatorController();
			LoadFailSafeBeedrill_IdleAnimatorController();
		}
		private void LoadFailSafeBeedrill_ConvertToAnimatorController()
		{
			LFSBeedrill_AnimatorCCA.BEParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeBeedrill_MovementAnimatorController()
		{
			LFSBeedrill_AnimatorCMA.BEParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeBeedrill_IdleAnimatorController()
		{
			LFSBeedrill_AnimatorICA.BEParentMom_IdleAnimatorController();
		}
	}
}