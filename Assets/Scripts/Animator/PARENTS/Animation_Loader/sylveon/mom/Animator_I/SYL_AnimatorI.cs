using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.Animator_I
{
	public class LFS_SylveonFailSafe : MonoBehaviour
	{
		public Animator SylveonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private SylveonParentMom_ConverterAnimatorController LFSSylveon_AnimatorCCA;
		private SylveonParentMom_MovementAnimatorController LFSSylveon_AnimatorCMA;
		private SylveonParentMom_IdleAnimatorController LFSSylveon_AnimatorICA;

		public void LoadFailSafeSylveon_AnimatorController()
		{
			LoadFailSafeSylveon_ConvertToAnimatorController();
			LoadFailSafeSylveon_MovementAnimatorController();
			LoadFailSafeSylveon_IdleAnimatorController();
		}
		private void LoadFailSafeSylveon_ConvertToAnimatorController()
		{
			LFSSylveon_AnimatorCCA.SYLParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeSylveon_MovementAnimatorController()
		{
			LFSSylveon_AnimatorCMA.SYLParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeSylveon_IdleAnimatorController()
		{
			LFSSylveon_AnimatorICA.SYLParentMom_IdleAnimatorController();
		}
	}
}