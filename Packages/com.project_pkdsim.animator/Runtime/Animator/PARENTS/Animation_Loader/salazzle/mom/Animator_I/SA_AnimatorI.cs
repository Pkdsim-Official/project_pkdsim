using project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.Animator_I
{
	public class SalazzleFailSafe : MonoBehaviour 
	{
		public Animator SalazzleParentMom_Animator;
		public RuntimeAnimatorController someController;

		private SalazzleParentMom_ConverterToAnimatorController SalazzleParentMom_AnimatorCCA;
		private SalazzleParent_AnimatorMovementController SalazzleParentMom_AnimatorCMA;
		private SalazzleParentMom_IdleAnimatorController SalazzleParentMom_AnimatorICA;

		public void LoadFailSafeSalazzleParentMom_AnimatorController()
		{
			LoadFailSafeSalazzleParentMom_ConvertToAnimatorController();
			LoadFailSafeSalazzleParentMom_MovementAnimatorController();
			LoadFailSafeSalazzleParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeSalazzleParentMom_ConvertToAnimatorController()
		{
			SalazzleParentMom_AnimatorCCA.SA_ConverterToAnimatorController();
		}
		private void LoadFailSafeSalazzleParentMom_MovementAnimatorController()
		{
			SalazzleParentMom_AnimatorCMA.SA_MovementAnimatorController();
		}
		private void LoadFailSafeSalazzleParentMom_IdleAnimatorController()
		{
			SalazzleParentMom_AnimatorICA.SA_IdleAnimatorController();
		}
	}
}