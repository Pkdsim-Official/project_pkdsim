using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.idlebaseanimation;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.movementbasedanimations;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Animator_I
{
	public class LFS_GardevoirFailSafe : MonoBehaviour 
	{
		public Animator GardevoirParentDad_Animator;
		public RuntimeAnimatorController someController;

		private GardevoirConverterAnimatorController LFSGardevoir_AnimatorCCA;
		private GardevoirParentDad_MovementAnimatorController LFSGardevoir_AnimatorCMA;
		private Gardevoir_IdleAnimatorController LFSGardevoir_AnimatorICA;


		public void LoadFailSafeGardevoir_AnimatorController()
		{
			LoadFailSafeGardevoir_ConvertToAnimatorController();
			LoadFailSafeGardevoir_MovementAnimatorController();
			LoadFailSafeGardevoir_IdleAnimatorController();
		}
		private void LoadFailSafeGardevoir_ConvertToAnimatorController()
		{
			LFSGardevoir_AnimatorCCA.GARD_ConverterAnimatorController();
		}
		private void LoadFailSafeGardevoir_MovementAnimatorController()
		{
			LFSGardevoir_AnimatorCMA.GARDMovementAnimatorController();
		}
		private void LoadFailSafeGardevoir_IdleAnimatorController()
		{
			LFSGardevoir_AnimatorICA.GARD_IdleAnimatorController();
		}
	}
}