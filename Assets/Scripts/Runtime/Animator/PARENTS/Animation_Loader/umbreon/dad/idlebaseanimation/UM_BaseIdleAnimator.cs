using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.idlebaseanimation
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