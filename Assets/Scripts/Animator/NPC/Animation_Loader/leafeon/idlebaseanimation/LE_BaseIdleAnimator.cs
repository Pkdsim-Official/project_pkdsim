using project_pkdsim.Models.ANIMATOR.NPC.Leafeon.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Leafeon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Leafeon.idlebaseanimation
{
	public class Leafeon_IdleAnimatorController : MonoBehaviour 
	{
		private LE_IdleStanding LE_idlestanding;
		
		private LE_IdleSitting LE_idlesitting;

		private void LE_BaseIdleAnimatorController()
		{
			LE_idlestanding.LE_IdleStandingController();
			LE_idlesitting.LE_IdleSittingController();	
		}
	}
}