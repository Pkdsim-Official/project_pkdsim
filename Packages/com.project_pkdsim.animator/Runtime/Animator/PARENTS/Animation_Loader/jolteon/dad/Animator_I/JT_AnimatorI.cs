using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.Animator_I
{
	public class GLParentDad_AnimatorI : MonoBehaviour 
	{
		public Animator JolteonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private JolteonParentDad_ConverterAnimatorController JolteonParentDad_AnimatorCCA;
		private JolteonParentDad_MovementAnimatorController JolteonParentDad_AnimatorCMA;
		private JolteonParentDad_IdleAnimatorController JolteonParentDad_AnimatorICA;

		private void JolteonParentDad_AnimatorController()
		{
			JolteonParentDad_Animator = gameObject.GetComponent<Animator>();
			JolteonParentDad_Animator.runtimeAnimatorController = someController;
		}
		private void ConvertToAnimatorController()
		{
			JolteonParentDad_AnimatorCCA.JTParentDad_ConverterAnimatorController();
		}
		private void MovementAnimatorController()
		{
			JolteonParentDad_AnimatorCMA.JTParentDad_MovementAnimatorController();
		}
		private void JolteonParentDad_IdleAnimatorController()
		{
			JolteonParentDad_AnimatorICA.JTParentDad_IdleAnimatorController();
		}
	}
}