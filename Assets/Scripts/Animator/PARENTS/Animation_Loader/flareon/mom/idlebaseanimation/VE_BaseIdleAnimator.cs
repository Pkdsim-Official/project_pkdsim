using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation
{
	public class FlareonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private FLParentMom_IdleStanding FLParentMom_Idlestanding;
		
		private FLParentMom_IdleSitting FLParentMom_Idlesitting;
		
		public void	FLParentMom_IdleAnimatorController()
		{
			FLParentMom_IdleStandingAnimatorController();
			FLParentMom_IdleSittingAnimatorController();
		}
		private void FLParentMom_IdleStandingAnimatorController()
		{
			FLParentMom_Idlestanding.FLParentMom_IdleStandingController();
		}
		private void FLParentMom_IdleSittingAnimatorController()
		{
			FLParentMom_Idlesitting.FLParentMom_IdleSittingController();
		}
	}
}