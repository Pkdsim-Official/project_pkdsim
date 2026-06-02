using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation
{
	public class UmbreonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private UMParentMom_IdleStanding UMParentMom_idlestanding;
		
		private UMParentMom_IdleSitting UMParentMom_idlesitting;
		public void UMParentMom_IdleAnimatorController()
		{
			UMParentMom_idlestanding.UMParentMom_IdleStandingController();
			UMParentMom_idlesitting.UMParentMom_IdleSittingController();	
		}
	}
}