using project_pkdsim.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation
{
	public class FlareonParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private FLParentDad_IdleStanding FLParentDad_idlestanding;
		
		private FLParentDad_IdleSitting FLParentDad_idlesitting;
		
		public void FLParentDad_IdleAnimatorController()
		{
			FLParentDad_idlestanding.FLParentDad_IdleStandingController();
			FLParentDad_idlesitting.FLParentDad_IdleSittingController();	
		}
	}
}