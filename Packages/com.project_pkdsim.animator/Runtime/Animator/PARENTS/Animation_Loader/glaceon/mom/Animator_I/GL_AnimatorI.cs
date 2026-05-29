using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.Animator_I
{
	public class GL_AnimatorI : MonoBehaviour 
	{
		public Animator Glaceon_Animator;
		public RuntimeAnimatorController someController;

		private Glaceon_AnimatorControllerCoverterAnimator Glaceon_AnimatorCCA;
		private GlaceonParent_AnimatorMovementController Glaceon_AnimatorCMA;
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