using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation
{
	public class UmbreonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private UMParentMom_IdleStanding UMParentMom_Idlestanding;
		
		private UMParentMom_IdleSitting UMParentMom_Idlesitting;
		
		public void	UMParentMom_IdleAnimatorController()
		{
			UMParentMom_IdleStandingAnimatorController();
			UMParentMom_IdleSittingAnimatorController();
		}
		private void UMParentMom_IdleStandingAnimatorController()
		{
			UMParentMom_Idlestanding.UMParentMom_IdleStandingController();
		}
		private void UMParentMom_IdleSittingAnimatorController()
		{
			UMParentMom_Idlesitting.UMParentMom_IdleSittingController();
		}
	}
}