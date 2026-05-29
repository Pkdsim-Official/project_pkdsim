using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.Mom.Animator_I
{
	public class PrimarinaFailSafe : MonoBehaviour 
	{
		public Animator PrimarinaParentMom_Animator;
		public RuntimeAnimatorController someController;

		private PrimarinaParentMom_ConverterToAnimatorController PrimarinaParentMom_AnimatorCCA;
		private PrimarinaParentMom_AnimatorMovementController PrimarinaParentMom_AnimatorCMA;
		private PrimarinaParentMom_IdleAnimatorController PrimarinaParentMom_AnimatorICA;


		public void LoadFailSafePrimarinaParentMom_AnimatorController()
		{
			LoadFailSafePrimarinaParentMom_ConvertToAnimatorController();
			LoadFailSafePrimarinaParentMom_MovementAnimatorController();
			LoadFailSafePrimarinaParentMom_IdleAnimatorController();
		}
		private void LoadFailSafePrimarinaParentMom_ConvertToAnimatorController()
		{
			PrimarinaParentMom_AnimatorCCA.PR_ConverterToAnimatorController();
		}
		private void LoadFailSafePrimarinaParentMom_MovementAnimatorController()
		{
			PrimarinaParentMom_AnimatorCMA.PR_MovementAnimatorController();
		}
		private void LoadFailSafePrimarinaParentMom_IdleAnimatorController()
		{
			PrimarinaParentMom_AnimatorICA.PR_IdleAnimatorController();
		}
	}
}