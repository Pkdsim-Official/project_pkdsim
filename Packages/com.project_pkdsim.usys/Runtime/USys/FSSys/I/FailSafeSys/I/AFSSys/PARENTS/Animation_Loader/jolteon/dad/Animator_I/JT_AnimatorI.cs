using project_pkdsim.ANIMATOR.Parents.Jolteon.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Jolteon.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Jolteon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Animator_I
{
	public class JT_AnimatorI : MonoBehaviour 
	{
		public Animator Jolteon_Animator;
		public RuntimeAnimatorController someController;

		private Jolteon_ConverterAnimatorController Jolteon_AnimatorCCA;
		private JolteonParent_AnimatorMovementController Jolteon_AnimatorCMA;
		private Jolteon_AnimatorIdleController Jolteon_AnimatorICA;

		private void Jolteon_AnimatorController()
		{
			Jolteon_Animator = gameObject.GetComponent<Animator>();
			Jolteon_Animator.runtimeAnimatorController = someController;
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