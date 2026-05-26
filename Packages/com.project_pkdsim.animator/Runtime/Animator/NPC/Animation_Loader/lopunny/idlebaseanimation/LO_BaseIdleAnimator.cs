using project_pkdsim.ANIMATOR.NPC.Lopunny.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Lopunny.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lopunny.idlebaseanimation
{
	public class Lopunny_IdleAnimatorController : MonoBehaviour 
	{
		private LOIdleStanding Lopunnyidlestanding;
		
		private LO_IdleSitting Lopunnyidlesitting;
		
		public void	LO_IdleAnimatorController()
		{
			LOIdleStandingAnimatorController();
			LO_IdleSittingAnimatorController();
		}
		private void LOIdleStandingAnimatorController()
		{
			Lopunnyidlestanding.LOIdleStandingController();
		}
		private void LO_IdleSittingAnimatorController()
		{
			Lopunnyidlesitting.LO_IdleSittingController();
		}
	}
}