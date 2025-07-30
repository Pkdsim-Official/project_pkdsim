using project_pkdsim.ANIMATOR.Npcs.Jolteon.converteranimations;
using project_pkdsim.ANIMATOR.Npcs.Jolteon.idlebaseanimation;
using project_pkdsim.ANIMATOR.Npcs.Jolteon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Jolteon.Animator_I
{
	public class JT_AnimatorI : MonoBehaviour 
	{
		public Animator Jolteon_Animator;
		public RuntimeAnimatorController someController;

		private Jolteon_ConverterAnimatorController Jolteon_AnimatorCCA;
		private Jolteon_MovementAnimatorController Jolteon_AnimatorCMA;
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