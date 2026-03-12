using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.converteranimations;
using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.movementbasedanimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.Animator_I
{
	public class VAPOR_AnimatorI : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public RuntimeAnimatorController someController;

		private Vaporeon_CoverterAnimatorController Vaporeon_AnimatorCCA;
		private Vaporeon_MovementAnimatorController Vaporeon_AnimatorCMA;
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