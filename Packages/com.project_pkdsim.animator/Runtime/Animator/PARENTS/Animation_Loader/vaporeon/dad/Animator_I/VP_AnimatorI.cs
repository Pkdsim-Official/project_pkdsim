using project_pkdsim.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Dad.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Dad.Animator_I
{
	public class VAPOR_AnimatorI : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public RuntimeAnimatorController someController;

		private Vaporeon_ConverterAnimatorController Vaporeon_AnimatorCCA;
		private VaporeonParent_MovementAnimatorController Vaporeon_AnimatorCMA;
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