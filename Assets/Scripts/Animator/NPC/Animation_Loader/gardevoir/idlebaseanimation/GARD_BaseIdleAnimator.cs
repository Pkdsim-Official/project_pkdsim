using project_pkdsim.ANIMATOR.NPC.Gardevoir.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Gardevoir.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Gardevoir.idlebaseanimation
{
	public class GardevoirIdleAnimatorController : MonoBehaviour 
	{
		private GARDIdleStanding Gardevoiridlestanding;
		
		private GARDIdleSitting Gardevoiridlesitting;
		
		public void	GARDIdleAnimatorController()
		{
			GARDIdleStandingAnimatorController();
			GARDIdleSittingAnimatorController();
		}
		private void GARDIdleStandingAnimatorController()
		{
			Gardevoiridlestanding.GARDIdleStandingController();
		}
		private void GARDIdleSittingAnimatorController()
		{
			Gardevoiridlesitting.GARDIdleSittingController();
		}
	}
}