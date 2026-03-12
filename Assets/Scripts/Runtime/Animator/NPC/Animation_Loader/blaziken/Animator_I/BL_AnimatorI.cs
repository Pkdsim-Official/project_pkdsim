using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Blaziken.Animator_I
{
	public class LFS_BlazikenFailSafe : MonoBehaviour 
	{
		public Animator Blaziken_Animator;
		public RuntimeAnimatorController someController;

		private BlazikenCoverterAnimatorController LFSBlaziken_AnimatorCCA;
		private Blaziken_MovementAnimatorController LFSBlaziken_AnimatorCMA;
		private Blaziken_IdleAnimatorController LFSBlaziken_AnimatorICA;


		public void LoadFailSafeBlaziken_AnimatorController()
		{
			LoadFailSafeBlaziken_ConvertToAnimatorController();
			LoadFailSafeBlaziken_MovementAnimatorController();
			LoadFailSafeBlaziken_IdleAnimatorController();
		}
		private void LoadFailSafeBlaziken_ConvertToAnimatorController()
		{
			LFSBlaziken_AnimatorCCA.BLCoverterToAnimatorController();
		}
		private void LoadFailSafeBlaziken_MovementAnimatorController()
		{
			LFSBlaziken_AnimatorCMA.BLMovementAnimatorController();
		}
		private void LoadFailSafeBlaziken_IdleAnimatorController()
		{
			LFSBlaziken_AnimatorICA.BL_IdleAnimatorController();
		}
	}
}