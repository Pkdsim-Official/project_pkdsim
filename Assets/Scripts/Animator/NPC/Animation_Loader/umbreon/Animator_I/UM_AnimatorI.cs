
using project_pkdsim.Models.ANIMATOR.NPC.Umbreon.movementbasedanimations;
using project_pkdsim.Models.ANIMATOR.NPC.Umbreon.idlebaseanimation;
using project_pkdsim.Models.ANIMATOR.NPC.Umbreon.converteranimations;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Umbreon.Animator_I
{
	public class UM_AnimatorI : MonoBehaviour 
	{		
		public Animator Umbreon_Animator;
		public RuntimeAnimatorController someController;

		private Umbreon_AnimatorBaseConverterController Umbreon_AnimatorCCA;
		private Umbreon_AnimatorBaseMovementController Umbreon_AnimatorCMA;
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
		private void IdleAnimatorController()
		{
			
		}
	}
}