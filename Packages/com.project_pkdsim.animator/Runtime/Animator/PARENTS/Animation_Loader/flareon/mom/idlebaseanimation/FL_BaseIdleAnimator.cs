using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation
{
	public class FlareonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private FLParentMom_IdleStanding FLParentMom_idlestanding;
		
		private FLParentMom_IdleSitting FLParentMom_idlesitting;
		
		public void FLParentMom_IdleAnimatorController()
		{
			FLParentMom_idlestanding.FLParentMom_IdleStandingController();
			FLParentMom_idlesitting.FLParentMom_IdleSittingController();	
		}
	}
}