using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation
{
	public class VespiquenParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private VEParentMom_IdleStanding VEParentMom_idlestanding;
		
		private VEParentMom_IdleSitting VEParentMom_idlesitting;
		
		public void	VEParentMom_IdleAnimatorController()
		{
			VEParentMom_IdleStandingAnimatorController();
			VEParentMom_IdleSittingAnimatorController();
		}
		private void VEParentMom_IdleStandingAnimatorController()
		{
			VEParentMom_idlestanding.VEParentMom_IdleStandingController();
		}
		private void VEParentMom_IdleSittingAnimatorController()
		{
			VEParentMom_idlesitting.VEParentMom_IdleSittingController();
		}
	}
}