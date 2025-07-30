using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation
{
	public class FlareonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private VEParentMom_IdleStanding VEParentMom_Idlestanding;
		
		private VEParentMom_IdleSitting VEParentMom_Idlesitting;
		
		public void	VE_IdleAnimatorController()
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