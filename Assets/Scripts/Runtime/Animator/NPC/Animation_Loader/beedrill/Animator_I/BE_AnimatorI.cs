using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Beedrill.Animator_I
{
	public class LFS_BeedrillFailSafe : MonoBehaviour 
	{
		public Animator Beedrill_Animator;
		public RuntimeAnimatorController someController;

		private BeedrillCoverterAnimatorController LFSBeedrill_AnimatorCCA;
		private Beedrill_MovementAnimatorController LFSBeedrill_AnimatorCMA;
		private Beedrill_IdleAnimatorController LFSBeedrill_AnimatorICA;


		public void LoadFailSafeBeedrill_AnimatorController()
		{
			LoadFailSafeBeedrill_ConvertToAnimatorController();
			LoadFailSafeBeedrill_MovementAnimatorController();
			LoadFailSafeBeedrill_IdleAnimatorController();
		}
		private void LoadFailSafeBeedrill_ConvertToAnimatorController()
		{
			LFSBeedrill_AnimatorCCA.BE_CoverterToAnimatorController();
		}
		private void LoadFailSafeBeedrill_MovementAnimatorController()
		{
			LFSBeedrill_AnimatorCMA.BE_MovementAnimatorController();
		}
		private void LoadFailSafeBeedrill_IdleAnimatorController()
		{
			LFSBeedrill_AnimatorICA.BE_IdleAnimatorController();
		}
	}
}