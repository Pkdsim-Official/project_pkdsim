
using project_pkdsim.ANIMATOR.Parents.Umbreon.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Umbreon.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Umbreon.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Animator_I
{
	public class UM_AnimatorI : MonoBehaviour 
	{		
		public Animator Umbreon_Animator;
		public RuntimeAnimatorController someController;

		private Umbreon_ConverterAnimatorController Umbreon_AnimatorCCA;
		private UmbreonParent_MovementAnimatorController Umbreon_AnimatorCMA;
		private Umbreon_IdleAnimatorController Umbreon_AnimatorICA;

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