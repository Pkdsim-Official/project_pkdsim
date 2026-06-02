using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation
{
	public class VaporeonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private VPParentMom_IdleStanding VPParentMom_idlestanding;
		
		private VPParentMom_IdleSitting VPParentMom_idlesitting;
		public void VPParentMom_IdleAnimatorController()
		{
			VPParentMom_idlestanding.VPParentMom_IdleStandingController();
			VPParentMom_idlesitting.VPParentMom_IdleSittingController();	
		}
	}
}