using Project_Pkdsim.ANIMATOR.Parents.Gardevoir.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Gardevoir.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Gardevoir.idlebaseanimation
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