using project_pkdsim.ANIMATOR.NPC.Jolteon.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Jolteon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Jolteon.idlebaseanimation
{
	public class Jolteon_IdleAnimatorController : MonoBehaviour 
	{
		private JT_IdleStanding JT_idlestanding;
		
		private JT_IdleSitting JT_idlesitting;

		private void JTParentMom_IdleAnimatorController()
		{
			JT_idlestanding.JT_IdleStandingController();
			JT_idlesitting.JT_IdleSittingController();	
		}
	}
}