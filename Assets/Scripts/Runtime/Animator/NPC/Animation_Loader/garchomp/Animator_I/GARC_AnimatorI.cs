using Project_Pkdsim.ANIMATOR.Npcs.Garchomp.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Garchomp.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Garchomp.Animator_I
{
	public class LFS_GarchompFailSafe : MonoBehaviour 
	{
		public Animator Garchomp_Animator;
		public RuntimeAnimatorController someController;

		private GarchompCoverterAnimatorController LFSGarchomp_AnimatorCCA;
		private Garchomp_MovementAnimatorController LFSGarchomp_AnimatorCMA;
		private Garchomp_IdleAnimatorController LFSGarchomp_AnimatorICA;


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