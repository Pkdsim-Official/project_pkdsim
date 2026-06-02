using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.Animator_I
{
	public class LEParent_AnimatorI : MonoBehaviour 
	{
		public Animator LeafeonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private LeafeonParentMom_ConverterAnimatorController LeafeonParentMom_AnimatorCCA;
		private LeafeonParentMom_MovementAnimatorController LeafeonParentMom_AnimatorCMA;
		private LeafeonParentMom_IdleAnimatorController  LeafeonParentMom_AnimatorICA;

		private void LeafeonParentMom_AnimatorController()
		{
			LeafeonParentMom_Animator = gameObject.GetComponent<Animator>();
			LeafeonParentMom_Animator.runtimeAnimatorController = someController;
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