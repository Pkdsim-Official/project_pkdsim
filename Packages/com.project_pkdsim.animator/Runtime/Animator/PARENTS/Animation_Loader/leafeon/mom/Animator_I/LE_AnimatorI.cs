using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation;
using UnityEngine;

namespace  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.Animator_I
{
	public class LE_AnimatorI : MonoBehaviour 
	{
		public Animator Leafeon_Animator;
		public RuntimeAnimatorController someController;

		private Leafeon_ConverterToAnimatorController Leafeon_AnimatorCCA;
		private LeafeonParent_AnimatorMovementController Leafeon_AnimatorCMA;
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