using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.Animator_I
{
	public class VaporeonParentDad_FailSafe : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public RuntimeAnimatorController someController;

		private VaporeonParentDad_ConverterAnimatorController Vaporeon_AnimatorCCA;
		private VaporeonParentDad_MovementAnimatorController Vaporeon_AnimatorCMA;
		private VaporeonParentDad_IdleAnimatorController Vaporeon_AnimatorICA;
		
		public void LoadFailSafeVaporeonParentDad_AnimatorController()
		{
			VaporeonParentDad_ConvertToAnimatorController();
			VaporeonParentDad_MovementAnimatorController();
			VaporeonParentDad_IdleAnimatorController();
		}
		private void VaporeonParentDad_ConvertToAnimatorController()
		{
			Vaporeon_AnimatorCCA.VPParentDad_ConverterAnimatorController();
		}
		private void VaporeonParentDad_MovementAnimatorController()
		{
			Vaporeon_AnimatorCMA.VPParentDad_MovementAnimatorController();
		}
		private void VaporeonParentDad_IdleAnimatorController()
		{
			Vaporeon_AnimatorICA.VPParentDad_IdleAnimatorController();
		}
	}
}