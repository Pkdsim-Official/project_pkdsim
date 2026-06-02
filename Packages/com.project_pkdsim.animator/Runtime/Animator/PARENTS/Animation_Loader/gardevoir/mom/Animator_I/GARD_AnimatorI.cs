using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.Animator_I
{
	public class GardevoirFailSafe : MonoBehaviour 
	{
		public Animator GardevoirParentMom_Animator;
		public RuntimeAnimatorController someController;

		private GardevoirParentMom_ConverterAnimatorController GardevoirParentMom_AnimatorCCA;
		private GardevoirParentMom_MovementAnimatorController GardevoirParentMom_AnimatorCMA;
		private GardevoirParentMom_IdleAnimatorController GardevoirParentMom_AnimatorICA;


		public void LoadFailSafeGardevoirParentMom_AnimatorController()
		{
			LoadFailSafeGardevoirParentMom_ConvertToAnimatorController();
			LoadFailSafeGardevoirParentMom_MovementAnimatorController();
			LoadFailSafeGardevoirParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeGardevoirParentMom_ConvertToAnimatorController()
		{
			GardevoirParentMom_AnimatorCCA.GARD_ConverterAnimatorController();
		}
		private void LoadFailSafeGardevoirParentMom_MovementAnimatorController()
		{
			GardevoirParentMom_AnimatorCMA.GARDMovementAnimatorController();
		}
		private void LoadFailSafeGardevoirParentMom_IdleAnimatorController()
		{
			GardevoirParentMom_AnimatorICA.GARD_IdleAnimatorController();
		}
	}
}