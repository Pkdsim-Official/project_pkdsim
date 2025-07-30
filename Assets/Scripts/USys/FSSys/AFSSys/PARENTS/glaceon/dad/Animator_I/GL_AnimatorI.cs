using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.Animator_I
{
	public class GL_AnimatorI : MonoBehaviour
	{
		public Animator GlaceonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private GlaceonParentDad_ConverterAnimatorController LFSGlaceon_AnimatorCCA;
		private GlaceonParentDad_MovementAnimatorController LFSGlaceon_AnimatorCMA;
		private GlaceonParentDad_AnimatorIdleController LFSGlaceon_AnimatorICA;

		public void LoadFailSafeGlaceon_AnimatorController()
		{
			LoadFailSafeGlaceon_ConvertToAnimatorController();
			LoadFailSafeGlaceon_MovementAnimatorController();
			LoadFailSafeGlaceon_IdleAnimatorController();
		}
		private void LoadFailSafeGlaceon_ConvertToAnimatorController()
		{
			LFSGlaceon_AnimatorCCA.GLParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeGlaceon_MovementAnimatorController()
		{
			LFSGlaceon_AnimatorCMA.GLParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeGlaceon_IdleAnimatorController()
		{
			LFSGlaceon_AnimatorICA.GLParentDad_IdleAnimatorController();
		}
	}
}