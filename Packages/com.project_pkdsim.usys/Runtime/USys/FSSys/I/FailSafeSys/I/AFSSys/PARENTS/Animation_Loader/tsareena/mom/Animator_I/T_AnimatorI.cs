using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.Animator_I
{
	public class TsareenaParentMom_FailSafe : MonoBehaviour 
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
			TsareenaParentMom_AnimatorCCA.T_ConverterAnimatorController();
		}
		private void LoadFailSafeTsareenaParentMom_MovementAnimatorController()
		{
			TsareenaParentMom_AnimatorCMA.TMovementAnimatorController();
		}
		private void LoadFailSafeTsareenaParentMom_IdleAnimatorController()
		{
			TsareenaParentMom_AnimatorICA.T_IdleAnimatorController();
		}
	}
}