using project_pkdsim.ANIMATOR.NPC.Leafeon.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Leafeon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Leafeon.idlebaseanimation
{
	public class Leafeon_IdleAnimatorController : MonoBehaviour 
	{
		private LE_IdleStanding LE_idlestanding;
		
		private LE_IdleSitting LE_idlesitting;

		private void LE_Base_IdleAnimatorController()
		{
			LE_idlestanding.LE_IdleStandingController();
			LE_idlesitting.LE_IdleSittingController();	
		}
	}
}