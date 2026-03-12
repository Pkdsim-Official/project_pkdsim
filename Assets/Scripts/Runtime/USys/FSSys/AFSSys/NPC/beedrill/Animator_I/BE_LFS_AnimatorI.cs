using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.Animator_I
{
	public class LFS_BeedrillFailSafe : MonoBehaviour 
	{
		public Animator Beedrill_Animator;
		public RuntimeAnimatorController someController;

		private Beedrill_LFS_CoverterAnimatorController LFSBeedrill_AnimatorCCA;
		private Beedrill_LFS_MovementAnimatorController LFSBeedrill_AnimatorCMA;
		private Beedrill_LFS_IdleAnimatorController LFSBeedrill_AnimatorICA;


		public void LoadFailSafeBeedrill_AnimatorController()
		{
			LoadFailSafeBeedrill_ConvertToAnimatorController();
			LoadFailSafeBeedrill_MovementAnimatorController();
			LoadFailSafeBeedrill_IdleAnimatorController();
		}
		private void LoadFailSafeBeedrill_ConvertToAnimatorController()
		{
			LFSBeedrill_AnimatorCCA.BE_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeBeedrill_MovementAnimatorController()
		{
			LFSBeedrill_AnimatorCMA.BE_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeBeedrill_IdleAnimatorController()
		{
			LFSBeedrill_AnimatorICA.BE_LFS_IdleAnimatorController();
		}
	}
}