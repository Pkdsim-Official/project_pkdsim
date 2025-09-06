using project_pkdsim.ANIMATOR.NPC.Lopunny.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Lopunny.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lopunny.idlebaseanimation
{
	public class LopunnyIdleAnimatorController : MonoBehaviour 
	{
		private LOIdleStanding Lopunnyidlestanding;
		
		private LOIdleSitting Lopunnyidlesitting;
		
		public void	LOIdleAnimatorController()
		{
			LOIdleStandingAnimatorController();
			LOIdleSittingAnimatorController();
		}
		private void LOIdleStandingAnimatorController()
		{
			Lopunnyidlestanding.LOIdleStandingController();
		}
		private void LOIdleSittingAnimatorController()
		{
			Lopunnyidlesitting.LOIdleSittingController();
		}
	}
}