using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.Animator_I
{
	public class LFS_BlazikenFailSafe : MonoBehaviour 
	{
		public Animator Blaziken_Animator;
		public RuntimeAnimatorController someController;

		private Blaziken_LFS_CoverterAnimatorController LFSBlaziken_AnimatorCCA;
		private Blaziken_LFS_MovementAnimatorController LFSBlaziken_AnimatorCMA;
		private Blaziken_LFS_IdleAnimatorController LFSBlaziken_AnimatorICA;


		public void LoadFailSafeBlaziken_AnimatorController()
		{
			LoadFailSafeBlaziken_ConvertToAnimatorController();
			LoadFailSafeBlaziken_MovementAnimatorController();
			LoadFailSafeBlaziken_IdleAnimatorController();
		}
		private void LoadFailSafeBlaziken_ConvertToAnimatorController()
		{
			LFSBlaziken_AnimatorCCA.BL_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeBlaziken_MovementAnimatorController()
		{
			LFSBlaziken_AnimatorCMA.BL_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeBlaziken_IdleAnimatorController()
		{
			LFSBlaziken_AnimatorICA.BL_LFS_IdleAnimatorController();
		}
	}
}