using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.idlebaseanimation;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.Animator_I
{
	public class SYLParentDad_AnimatorI : MonoBehaviour
	{
		public Animator SylveonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private SylveonParentDad_ConverterAnimatorController LFSSylveon_AnimatorCCA;
		private SylveonParentDad_MovementAnimatorController LFSSylveon_AnimatorCMA;
		private SylveonParentDad_IdleAnimatorController LFSSylveon_AnimatorICA;

		private void ConvertToAnimatorController()
		{
			LFSSylveon_AnimatorCCA.SYLParentDad_ConverterAnimatorController();
		}
		private void MovementAnimatorController()
		{
			LFSSylveon_AnimatorCMA.SYLParentDad_MovementAnimatorController();
		}
		private void _IdleAnimatorController()
		{
			LFSSylveon_AnimatorICA.SYLParentDad_IdleAnimatorController();
		}
	}
}