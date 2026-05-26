using project_pkdsim.ANIMATOR.NPC.Jolteon.converteranimations;
using project_pkdsim.ANIMATOR.NPC.Jolteon.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Jolteon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Jolteon.Animator_I
{
	public class JT_AnimatorI : MonoBehaviour 
	{
		public Animator Jolteon_Animator;
		public RuntimeAnimatorController someController;

		private Jolteon_ConverterAnimatorController Jolteon_AnimatorCCA;
		private Jolteon_AnimatorBaseMovementController Jolteon_AnimatorCMA;
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