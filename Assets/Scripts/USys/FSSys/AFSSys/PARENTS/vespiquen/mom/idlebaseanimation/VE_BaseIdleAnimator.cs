using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation
{
	public class VespiquenParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private VEParentMom_IdleStanding VEParentMom_Idlestanding;
		
		private VEParentMom_IdleSitting VEParentMom_Idlesitting;
		
		public void	VEParentMom_IdleAnimatorController()
		{
			VEParentMom_IdleStandingAnimatorController();
			VEParentMom_IdleSittingAnimatorController();
		}
		private void VEParentMom_IdleStandingAnimatorController()
		{
			VEParentMom_Idlestanding.VEParentMom_IdleStandingController();
		}
		private void VEParentMom_IdleSittingAnimatorController()
		{
			VEParentMom_Idlesitting.VEParentMom_IdleSittingController();
		}
	}
}