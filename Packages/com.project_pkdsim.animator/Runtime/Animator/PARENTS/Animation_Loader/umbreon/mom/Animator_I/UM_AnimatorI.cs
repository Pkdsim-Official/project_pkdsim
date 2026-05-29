
using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.Animator_I
{
	public class UM_AnimatorI : MonoBehaviour 
	{		
		public Animator Umbreon_Animator;
		public RuntimeAnimatorController someController;

		private Umbreon_AnimatorBaseConverterController Umbreon_AnimatorCCA;
		private UmbreonParent_AnimatorMovementController Umbreon_AnimatorCMA;
		private Umbreon_AnimatorIdleController Umbreon_AnimatorICA;

		public void Umbreon_AnimatorController()
		{
			Umbreon_Animator.runtimeAnimatorController = someController;
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