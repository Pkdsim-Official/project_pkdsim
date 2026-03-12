using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Animator_I
{
	public class LFS_BlazikenFailSafe : MonoBehaviour 
	{
		public Animator BlazikenParentDad_Animator;
		public RuntimeAnimatorController someController;

		private BlazikenConverterAnimatorController LFSBlaziken_AnimatorCCA;
		private BlazikenParentDad_MovementAnimatorController LFSBlaziken_AnimatorCMA;
		private Blaziken_IdleAnimatorController LFSBlaziken_AnimatorICA;


		public void LoadFailSafeBlaziken_AnimatorController()
		{
			LoadFailSafeBlaziken_ConvertToAnimatorController();
			LoadFailSafeBlaziken_MovementAnimatorController();
			LoadFailSafeBlaziken_IdleAnimatorController();
		}
		private void LoadFailSafeBlaziken_ConvertToAnimatorController()
		{
			LFSBlaziken_AnimatorCCA.BLConverterAnimatorController();
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