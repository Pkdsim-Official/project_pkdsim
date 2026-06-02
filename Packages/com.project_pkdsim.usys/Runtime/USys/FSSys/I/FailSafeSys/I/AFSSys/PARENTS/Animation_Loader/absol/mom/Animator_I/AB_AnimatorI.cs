using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.Animator_I
{
	public class AbsolParentMom_FailSafe : MonoBehaviour 
	{
		public Animator AbsolParentMom_Animator;
		public RuntimeAnimatorController someController;

		private AbsolParentMom_ConverterAnimatorController AbsolParentMom_AnimatorCCA;
		private AbsolParentMom_MovementAnimatorController AbsolParentMom_AnimatorCMA;
		private AbsolParentMom_IdleAnimatorController AbsolParentMom_AnimatorICA;


		public void LoadFailSafeAbsolParentMom_AnimatorController()
		{
			LoadFailSafeAbsolParentMom_ConvertToAnimatorController();
			LoadFailSafeAbsolParentMom_MovementAnimatorController();
			LoadFailSafeAbsolParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeAbsolParentMom_ConvertToAnimatorController()
		{
			AbsolParentMom_AnimatorCCA.ABParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeAbsolParentMom_MovementAnimatorController()
		{
			AbsolParentMom_AnimatorCMA.ABParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeAbsolParentMom_IdleAnimatorController()
		{
			AbsolParentMom_AnimatorICA.ABParentMom_IdleAnimatorController();
		}
	}
}