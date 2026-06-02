using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.Animator_I
{
	public class LunalaParentMom_FailSafe : MonoBehaviour 
	{
		public Animator LunalaParentMom_Animator;
		public RuntimeAnimatorController someController;

		private LunalaParentMom_ConverterAnimatorController LunalaParentMom_AnimatorCCA;
		private LunalaParentMom_MovementAnimatorController LunalaParentMom_AnimatorCMA;
		private LunalaParentMom_IdleAnimatorController LunalaParentMom_AnimatorICA;


		public void LoadFailSafeLunalaParentMom_AnimatorController()
		{
			LoadFailSafeLunalaParentMom_ConvertToAnimatorController();
			LoadFailSafeLunalaParentMom_MovementAnimatorController();
			LoadFailSafeLunalaParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeLunalaParentMom_ConvertToAnimatorController()
		{
			LunalaParentMom_AnimatorCCA.LUNAParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeLunalaParentMom_MovementAnimatorController()
		{
			LunalaParentMom_AnimatorCMA.LUNAParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeLunalaParentMom_IdleAnimatorController()
		{
			LunalaParentMom_AnimatorICA.LUNAParentDadMom_IdleAnimatorController();
		}
	}
}