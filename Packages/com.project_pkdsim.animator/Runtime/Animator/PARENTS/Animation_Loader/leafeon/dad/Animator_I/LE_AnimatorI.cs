using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.idlebaseanimation;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.Animator_I
{
	public class LEParent_AnimatorI : MonoBehaviour 
	{
		public Animator LeafeonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private LeafeonParentDad_ConverterAnimatorController LeafeonParentDad_AnimatorCCA;
		private LeafeonParentDad_MovementAnimatorController LeafeonParentDad_AnimatorCMA;
		private LeafeonParentDad_IdleAnimatorController  LeafeonParentDad_AnimatorICA;

		private void LeafeonParentDad_AnimatorController()
		{
			LeafeonParentDad_Animator = gameObject.GetComponent<Animator>();
			LeafeonParentDad_Animator.runtimeAnimatorController = someController;
		}
		private void LeafeonParentDad_ConvertToAnimatorController()
		{
			LeafeonParentDad_AnimatorCCA.LEParentDad_ConverterAnimatorController();
		}
		private void LeafeonParentDad_MovementAnimatorController()
		{
			LeafeonParentDad_AnimatorCMA.LEParentDad_MovementAnimatorController();
		}
		private void LeafeonParentDad_IdleAnimatorController()
		{
			LeafeonParentDad_AnimatorICA.LEParentDad_IdleAnimatorController();
		}
	}
}