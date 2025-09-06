using project_pkdsim.ANIMATOR.NPC.Primarina.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Primarina.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Primarina.idlebaseanimation
{
	public class PrimarinaIdleAnimatorController : MonoBehaviour 
	{
		private PRIdleStanding Primarinaidlestanding;
		
		private PRIdleSitting Primarinaidlesitting;
		
		public void	PRIdleAnimatorController()
		{
			PRIdleStandingAnimatorController();
			PRIdleSittingAnimatorController();
		}
		private void PRIdleStandingAnimatorController()
		{
			Primarinaidlestanding.PRIdleStandingController();
		}
		private void PRIdleSittingAnimatorController()
		{
			Primarinaidlesitting.PRIdleSittingController();
		}
	}
}