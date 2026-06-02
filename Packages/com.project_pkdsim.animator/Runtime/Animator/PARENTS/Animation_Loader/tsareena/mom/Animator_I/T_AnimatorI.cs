using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.Animator_I
{
	public class TsareenaFailSafe : MonoBehaviour 
	{
		public Animator TsareenaParentMom_Animator;
		public RuntimeAnimatorController someController;

		private TsareenaParentMom_ConverterAnimatorController TsareenaParentMom_AnimatorCCA;
		private TsareenaParentMom_MovementAnimatorController TsareenaParentMom_AnimatorCMA;
		private TsareenaParentMom_IdleAnimatorController TsareenaParentMom_AnimatorICA;

		public void LoadFailSafeTsareenaParentMom_AnimatorController()
		{
			LoadFailSafeTsareenaParentMom_ConvertToAnimatorController();
			LoadFailSafeTsareenaParentMom_MovementAnimatorController();
			LoadFailSafeTsareenaParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeTsareenaParentMom_ConvertToAnimatorController()
		{
			TsareenaParentMom_AnimatorCCA.TParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeTsareenaParentMom_MovementAnimatorController()
		{
			TsareenaParentMom_AnimatorCMA.TParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeTsareenaParentMom_IdleAnimatorController()
		{
			TsareenaParentMom_AnimatorICA.TParentMom_IdleAnimatorController();
		}
	}
}