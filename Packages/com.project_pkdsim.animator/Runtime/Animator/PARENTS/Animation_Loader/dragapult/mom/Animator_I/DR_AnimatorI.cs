using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.Animator_I
{
	public class DragapultFailSafe : MonoBehaviour 
	{
		public Animator DelphoxParentMom_Animator;
		public RuntimeAnimatorController someController;

		private DelphoxParentMom_ConverterToAnimatorController DelphoxParentMom_AnimatorCCA;
		private DelphoxParentMom_AnimatorMovementController DelphoxParentMom_AnimatorCMA;
		private DelphoxParentMom_IdleAnimatorController DelphoxParentMom_AnimatorICA;


		public void LoadFailSafeDelphoxParentMom_AnimatorController()
		{
			LoadFailSafeDelphoxParentMom_ConvertToAnimatorController();
			LoadFailSafeDelphoxParentMom_MovementAnimatorController();
			LoadFailSafeDelphoxParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeDelphoxParentMom_ConvertToAnimatorController()
		{
			DelphoxParentMom_AnimatorCCA.DR_ConverterToAnimatorController();
		}
		private void LoadFailSafeDelphoxParentMom_MovementAnimatorController()
		{
			DelphoxParentMom_AnimatorCMA.DRMovementAnimatorController();
		}
		private void LoadFailSafeDelphoxParentMom_IdleAnimatorController()
		{
			DelphoxParentMom_AnimatorICA.DR_IdleAnimatorController();
		}
	}
}