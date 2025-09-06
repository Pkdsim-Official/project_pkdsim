using project_pkdsim.ANIMATOR.NPC.Garchomp.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Garchomp.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Garchomp.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Garchomp.Animator_I
{
	public class LFS_GarchompFailSafe : MonoBehaviour 
	{
		public Animator Garchomp_Animator;
		public RuntimeAnimatorController someController;

		private GarchompCoverterAnimatorController LFSGarchomp_AnimatorCCA;
		private Garchomp_AnimatorBaseMovementController LFSGarchomp_AnimatorCMA;
		private GarchompIdleAnimatorController LFSGarchomp_AnimatorICA;


		public void LoadFailSafeGarchomp_AnimatorController()
		{
			LoadFailSafeGarchomp_ConvertToAnimatorController();
			LoadFailSafeGarchomp_MovementAnimatorController();
			LoadFailSafeGarchomp_IdleAnimatorController();
		}
		private void LoadFailSafeGarchomp_ConvertToAnimatorController()
		{
			LFSGarchomp_AnimatorCCA.GARCCoverterToAnimatorController();
		}
		private void LoadFailSafeGarchomp_MovementAnimatorController()
		{
			LFSGarchomp_AnimatorCMA.GARCMovementAnimatorController();
		}
		private void LoadFailSafeGarchomp_IdleAnimatorController()
		{
			LFSGarchomp_AnimatorICA.GARC_IdleAnimatorController();
		}
	}
}