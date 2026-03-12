using Project_Pkdsim.ANIMATOR.Npcs.Flareon.converteranimations;
using Project_Pkdsim.ANIMATOR.Npcs.Flareon.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Flareon.movementbasedanimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Flareon.Animator_I
{
	public class FL_AnimatorI : MonoBehaviour 
	{
		public Animator Flareon_Animator;
		public RuntimeAnimatorController someController;

		private Flareon_AnimatorConverterController Flareon_AnimatorCCA;
		private Flareon_MovementAnimatorController Flareon_AnimatorCMA;
		private Flareon_AnimatorIdleController Flareon_AnimatorICA;
		
		private void Flareon_AnimatorController()
		{
			// Flareon_Animator = gameObject.GetComponent<Animator>();
			// Flareon_Animator.runtimeAnimatorController = someController;
		}
		private void ConvertToAnimatorController()
		{
			//Flareon_AnimatorCCA;
		}
		private void MovementAnimatorController()
		{
			//Flareon_AnimatorCMA	;
		}
		private void _IdleAnimatorController()
		{
			//Flareon_AnimatorICA;		
		}
	}
}