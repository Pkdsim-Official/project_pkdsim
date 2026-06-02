using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation
{
	public class VaporeonParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private VPParentDad_IdleStanding VPParentDad_idlestanding;
		
		private VPParentDad_IdleSitting VPParentDad_idlesitting;
		public void VPParentDad_IdleAnimatorController()
		{
			VPParentDad_idlestanding.VPParentDad_IdleStandingController();
			VPParentDad_idlesitting.VPParentDad_IdleSittingController();	
		}
	}
}