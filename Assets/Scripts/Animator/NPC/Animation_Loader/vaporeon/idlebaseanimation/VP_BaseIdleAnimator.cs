using project_pkdsim.ANIMATOR.NPC.Vaporeon.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Vaporeon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Vaporeon.idlebaseanimation
{
	public class Vaporeon_IdleAnimatorController : MonoBehaviour 
	{
		private VP_IdleStanding VP_idlestanding;
		
		private VP_IdleSitting VP_idlesitting;
		private void VP_Base_IdleAnimatorController()
		{
			VP_idlestanding.VP_IdleStandingController();
			VP_idlesitting.VP_IdleSittingController();	
		}
	}
}