using project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.Animator_I
{
	public class SalazzleFailSafe : MonoBehaviour 
	{
		public Animator Animator;
		public RuntimeAnimatorController someController;

		private SalazzleParentDad_ConverterAnimatorController SalazzleParentDad_AnimatorCCA;
		private SalazzleParentDad_MovementAnimatorController SalazzleParentDad_AnimatorCMA;
		private SalazzleParentDad_IdleAnimatorController SalazzleParentDad_AnimatorICA;

		public void LoadFailSafeAnimatorController()
		{
			LoadFailSafeSalazzleParentDad_ConvertToAnimatorController();
			LoadFailSafeSalazzleParentDad_MovementAnimatorController();
			LoadFailSafeSalazzleParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeSalazzleParentDad_ConvertToAnimatorController()
		{
			SalazzleParentDad_AnimatorCCA.SA_ConverterAnimatorController();
		}
		private void LoadFailSafeSalazzleParentDad_MovementAnimatorController()
		{
			SalazzleParentDad_AnimatorCMA.SA_MovementAnimatorController();
		}
		private void LoadFailSafeSalazzleParentDad_IdleAnimatorController()
		{
			SalazzleParentDad_AnimatorICA.SA_IdleAnimatorController();
		}
	}
}