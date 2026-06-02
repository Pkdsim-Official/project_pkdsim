using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.Animator_I
{
	public class JTParentMom_AnimatorI : MonoBehaviour 
	{
		public Animator JolteonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private JolteonParentMom_ConverterAnimatorController JolteonParentMom_AnimatorCCA;
		private JolteonParentMom_MovementAnimatorController JolteonParentMom_AnimatorCMA;
		private JolteonParentMom_IdleAnimatorController JolteonParentMom_AnimatorICA;

		private void JolteonParentMom_AnimatorController()
		{
			JolteonParentMom_Animator = gameObject.GetComponent<Animator>();
			JolteonParentMom_Animator.runtimeAnimatorController = someController;
		}
		private void ConvertToAnimatorController()
		{

		}
		private void MovementAnimatorController()
		{
			
		}
		private void _IdleAnimatorController()
		{
			
		}
	}
}