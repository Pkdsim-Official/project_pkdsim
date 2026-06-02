using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation
{
	public class Vaporeon_IdleAnimatorController : MonoBehaviour 
	{
		private VP_IdleStanding VP_idlestanding;
		
		private VP_IdleSitting VP_idlesitting;
		private void VPParent_IdleAnimatorController()
		{
			VP_idlestanding.VP_IdleStandingController();
			VP_idlesitting.VP_IdleSittingController();	
		}
	}
}