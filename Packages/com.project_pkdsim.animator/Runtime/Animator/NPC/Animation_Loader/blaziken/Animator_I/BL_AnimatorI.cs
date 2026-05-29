using project_pkdsim.ANIMATOR.NPC.Blaziken.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Blaziken.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Blaziken.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Blaziken.Animator_I
{
	public class LFS_BlazikenFailSafe : MonoBehaviour 
	{
		public Animator Blaziken_Animator;
		public RuntimeAnimatorController someController;

		private Blaziken_ConverterToAnimatorController LFSBlaziken_AnimatorCCA;
		private Blaziken_AnimatorMovementController LFSBlaziken_AnimatorCMA;
		private Blaziken_IdleAnimatorController LFSBlaziken_AnimatorICA;


		public void LoadFailSafeBlaziken_AnimatorController()
		{
			LoadFailSafeBlaziken_ConvertToAnimatorController();
			LoadFailSafeBlaziken_MovementAnimatorController();
			LoadFailSafeBlaziken_IdleAnimatorController();
		}
		private void LoadFailSafeBlaziken_ConvertToAnimatorController()
		{
			LFSBlaziken_AnimatorCCA.BL_ConverterToAnimatorController();
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