using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator GlaceonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private GlaceonParentMom_ConverterAnimatorController LFSGlaceon_AnimatorCCA;
		private GlaceonParentMom_MovementAnimatorController LFSGlaceon_AnimatorCMA;
		private GlaceonParentMom_IdleAnimatorController LFSGlaceon_AnimatorICA;


		public void LoadFailSafeGlaceon_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSGlaceon_AnimatorCCA.GLParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSGlaceon_AnimatorCMA.GLParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSGlaceon_AnimatorICA.GLParentMom_IdleAnimatorController();
		}
	}
}