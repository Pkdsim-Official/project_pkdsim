using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation
{
	public class VaporeonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private VPParentMom_IdleStanding VPParentMom_Idlestanding;
		
		private VPParentMom_IdleSitting VPParentMom_Idlesitting;
		
		public void	VPParentMom_IdleAnimatorController()
		{
			VPParentMom_IdleStandingAnimatorController();
			VPParentMom_IdleSittingAnimatorController();
		}
		private void VPParentMom_IdleStandingAnimatorController()
		{
			VPParentMom_Idlestanding.VPParentMom_IdleStandingController();
		}
		private void VPParentMom_IdleSittingAnimatorController()
		{
			VPParentMom_Idlesitting.VPParentMom_IdleSittingController();
		}
	}
}