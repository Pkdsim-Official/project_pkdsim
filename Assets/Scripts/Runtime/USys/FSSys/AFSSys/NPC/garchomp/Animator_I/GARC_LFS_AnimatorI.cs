using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.Animator_I
{
	public class LFS_GarchompFailSafe : MonoBehaviour 
	{
		public Animator Garchomp_Animator;
		public RuntimeAnimatorController someController;

		private Garchomp_LFS_CoverterAnimatorController LFSGarchomp_AnimatorCCA;
		private Garchomp_LFS_MovementAnimatorController LFSGarchomp_AnimatorCMA;
		private Garchomp_LFS_IdleAnimatorController LFSGarchomp_AnimatorICA;


		public void LoadFailSafeGarchomp_AnimatorController()
		{
			LoadFailSafeGarchomp_ConvertToAnimatorController();
			LoadFailSafeGarchomp_MovementAnimatorController();
			LoadFailSafeGarchomp_IdleAnimatorController();
		}
		private void LoadFailSafeGarchomp_ConvertToAnimatorController()
		{
			LFSGarchomp_AnimatorCCA.GARC_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeGarchomp_MovementAnimatorController()
		{
			LFSGarchomp_AnimatorCMA.GARC_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeGarchomp_IdleAnimatorController()
		{
			LFSGarchomp_AnimatorICA.GARC_LFS_IdleAnimatorController();
		}
	}
}