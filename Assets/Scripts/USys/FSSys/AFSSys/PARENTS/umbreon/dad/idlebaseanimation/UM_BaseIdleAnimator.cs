using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.idlebaseanimation
{
	public class UmbreonParentDad_AnimatorIdleController : MonoBehaviour 
	{
		private UMParentDad_IdleStanding UMParentDad_idlestanding;
		
		private UMParentDad_IdleSitting UMParentDad_idlesitting;
		public void UMParentDad_IdleAnimatorController()
		{
			UMParentDad_idlestanding.UMParentDad_IdleStandingController();
			UMParentDad_idlesitting.UMParentDad_IdleSittingController();	
		}
	}
}