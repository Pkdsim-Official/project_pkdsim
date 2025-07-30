using project_pkdsim.ANIMATOR.Player.idlebaseanimation;
using project_pkdsim.ANIMATOR.Player.movementbasedanimations;
using project_pkdsim.ANIMATOR.Player.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Player.Animator_I
{
	public class LFS_PlayerFailSafe : MonoBehaviour 
	{
		public Animator Player_Animator;
		public RuntimeAnimatorController someController;

		private PlayerCoverterAnimatorController LFSPlayer_AnimatorCCA;
		private Player_MovementAnimatorController LFSPlayer_AnimatorCMA;
		private Player_IdleAnimatorController LFSPlayer_AnimatorICA;

		public void LoadFailSafePlayer_AnimatorController()
		{
			LoadFailSafePlayer_ConvertToAnimatorController();
			LoadFailSafePlayer_MovementAnimatorController();
			LoadFailSafePlayer_IdleAnimatorController();
		}
		private void LoadFailSafePlayer_ConvertToAnimatorController()
		{
			LFSPlayer_AnimatorCCA.PL_CoverterToAnimatorController();
		}
		private void LoadFailSafePlayer_MovementAnimatorController()
		{
			LFSPlayer_AnimatorCMA.PL_MovementAnimatorController();
		}
		private void LoadFailSafePlayer_IdleAnimatorController()
		{
			LFSPlayer_AnimatorICA.PL_IdleAnimatorController();
		}
	}
}