using Project_Pkdsim.ANIMATOR.Parents.Garchomp.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Garchomp.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Garchomp.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Garchomp.Animator_I
{
	public class LFS_GarchompFailSafe : MonoBehaviour 
	{
		public Animator GarchompParentDad_Animator;
		public RuntimeAnimatorController someController;

		private GarchompConverterAnimatorController LFSGarchomp_AnimatorCCA;
		private GarchompParentDad_MovementAnimatorController LFSGarchomp_AnimatorCMA;
		private Garchomp_IdleAnimatorController LFSGarchomp_AnimatorICA;


		public void LoadFailSafeGarchomp_AnimatorController()
		{
			LoadFailSafeGarchomp_ConvertToAnimatorController();
			LoadFailSafeGarchomp_MovementAnimatorController();
			LoadFailSafeGarchomp_IdleAnimatorController();
		}
		private void LoadFailSafeGarchomp_ConvertToAnimatorController()
		{
			LFSGarchomp_AnimatorCCA.GARCConverterAnimatorController();
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