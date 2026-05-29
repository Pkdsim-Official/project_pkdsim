using project_pkdsim.ANIMATOR.Parents.Gardevoir.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Dad.idlebaseanimation
{
	public class Gardevoir_IdleAnimatorController : MonoBehaviour 
	{
		private GARDIdleStanding Gardevoiridlestanding;
		
		private GARDIdleSitting Gardevoiridlesitting;
		
		public void	GARD_IdleAnimatorController()
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