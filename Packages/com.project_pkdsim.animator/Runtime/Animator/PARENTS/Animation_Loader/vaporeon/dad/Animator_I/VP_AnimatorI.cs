using project_pkdsim.ANIMATOR.Parents.Vaporeon.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Animator_I
{
	public class VAPOR_AnimatorI : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public RuntimeAnimatorController someController;

		private Vaporeon_CoverterAnimatorController Vaporeon_AnimatorCCA;
		private VaporeonParent_AnimatorBaseMovementController Vaporeon_AnimatorCMA;
		private Vaporeon_IdleAnimatorController Vaporeon_AnimatorICA;
		
		private void Vaporeon_AnimatorController()
		{
			Vaporeon_Animator = gameObject.GetComponent<Animator>();
			Vaporeon_Animator.runtimeAnimatorController = someController;
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