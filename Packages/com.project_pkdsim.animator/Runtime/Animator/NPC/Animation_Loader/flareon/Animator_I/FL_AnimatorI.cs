using project_pkdsim.ANIMATOR.NPC.Flareon.converteranimations;
using project_pkdsim.ANIMATOR.NPC.Flareon.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Flareon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Flareon.Animator_I
{
	public class FL_AnimatorI : MonoBehaviour 
	{
		public Animator Flareon_Animator;
		public RuntimeAnimatorController someController;

		private Flareon_AnimatorConverterController Flareon_AnimatorCCA;
		private Flareon_AnimatorMovementController Flareon_AnimatorCMA;
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