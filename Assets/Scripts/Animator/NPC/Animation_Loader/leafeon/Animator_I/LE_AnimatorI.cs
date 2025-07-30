using project_pkdsim.ANIMATOR.Npcs.Leafeon.movementbasedanimations;
using project_pkdsim.ANIMATOR.Npcs.Leafeon.converteranimations;
using project_pkdsim.ANIMATOR.Npcs.Leafeon.idlebaseanimation;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Leafeon.Animator_I
{
	public class LE_AnimatorI : MonoBehaviour 
	{
		public Animator Leafeon_Animator;
		public RuntimeAnimatorController someController;

		private Leafeon_CoverterAnimatorController Leafeon_AnimatorCCA;
		private Leafeon_MovementAnimatorController Leafeon_AnimatorCMA;
		private Leafeon_IdleAnimatorController  Leafeon_AnimatorICA;

		private void Leafeon_AnimatorController()
		{
			Leafeon_Animator = gameObject.GetComponent<Animator>();
			Leafeon_Animator.runtimeAnimatorController = someController;
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