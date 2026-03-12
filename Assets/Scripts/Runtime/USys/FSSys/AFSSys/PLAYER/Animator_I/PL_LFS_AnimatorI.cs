using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.Animator_I
{
	public class LFS_PLAYERFailSafe : MonoBehaviour 
	{
		public Animator PLAYER_Animator;
		public RuntimeAnimatorController someController;

		private Player_LFS_CoverterAnimatorController LFSPlayer_AnimatorCCA;
		private Player_LFS_MovementAnimatorController LFSPlayer_AnimatorCMA;
		private Player_LFS_IdleAnimatorController LFSPlayer_AnimatorICA;


		public void LoadFailSafePlayer_AnimatorController()
		{
			LoadFailSafePlayer_ConvertToAnimatorController();
			LoadFailSafePlayer_MovementAnimatorController();
			LoadFailSafePlayer_IdleAnimatorController();
		}
		private void LoadFailSafePlayer_ConvertToAnimatorController()
		{
			LFSPlayer_AnimatorCCA.PL_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafePlayer_MovementAnimatorController()
		{
			LFSPlayer_AnimatorCMA.PL_LFS_MovementAnimatorController();
		}
		private void LoadFailSafePlayer_IdleAnimatorController()
		{
			LFSPlayer_AnimatorICA.PL_LFS_IdleAnimatorController();
		}
	}
}