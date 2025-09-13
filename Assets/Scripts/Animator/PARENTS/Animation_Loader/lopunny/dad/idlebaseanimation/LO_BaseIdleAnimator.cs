using project_pkdsim.ANIMATOR.Parents.Lopunny.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Lopunny.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.idlebaseanimation
{
	public class Lopunny_IdleAnimatorController : MonoBehaviour 
	{
		private LOIdleStanding Lopunnyidlestanding;
		
		private LOIdleSitting Lopunnyidlesitting;
		
		public void	LO_IdleAnimatorController()
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