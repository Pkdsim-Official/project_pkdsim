using project_pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations;
using project_pkdsim.ANIMATOR.Npcs.Glaceon.idlebaseanimation;
using project_pkdsim.ANIMATOR.Npcs.Glaceon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Glaceon.Animator_I
{
	public class GL_AnimatorI : MonoBehaviour 
	{
		public Animator Glaceon_Animator;
		public RuntimeAnimatorController someController;

		private Glaceon_AnimatorControllerCoverterAnimator Glaceon_AnimatorCCA;
		private Glaceon_MovementAnimatorController Glaceon_AnimatorCMA;
		private Glaceon_AnimatorIdleController Glaceon_AnimatorICA;


		private void Glaceon_AnimatorController()
		{
			Glaceon_Animator = gameObject.GetComponent<Animator>();
			Glaceon_Animator.runtimeAnimatorController = someController;
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