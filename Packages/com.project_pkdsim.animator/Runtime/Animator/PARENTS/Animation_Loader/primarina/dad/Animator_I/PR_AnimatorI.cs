using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.Dad.Animator_I
{
	public class PrimarinaFailSafe : MonoBehaviour 
	{
		public Animator PrimarinaParentDad_Animator;
		public RuntimeAnimatorController someController;

		private PrimarinaParentDad_ConverterToAnimatorController PrimarinaParentDad_AnimatorCCA;
		private PrimarinaParentDad_AnimatorMovementController PrimarinaParentDad_AnimatorCMA;
		private PrimarinaParentDad_IdleAnimatorController PrimarinaParentDad_AnimatorICA;

		public void LoadFailSafePrimarinaParentDad_AnimatorController()
		{
			LoadFailSafePrimarinaParentDad_ConvertToAnimatorController();
			LoadFailSafePrimarinaParentDad_MovementAnimatorController();
			LoadFailSafePrimarinaParentDad_IdleAnimatorController();
		}
		private void LoadFailSafePrimarinaParentDad_ConvertToAnimatorController()
		{
			PrimarinaParentDad_AnimatorCCA.PR_ConverterToAnimatorController();
		}
		private void LoadFailSafePrimarinaParentDad_MovementAnimatorController()
		{
			PrimarinaParentDad_AnimatorCMA.PRMovementAnimatorController();
		}
		private void LoadFailSafePrimarinaParentDad_IdleAnimatorController()
		{
			PrimarinaParentDad_AnimatorICA.PR_IdleAnimatorController();
		}
	}
}