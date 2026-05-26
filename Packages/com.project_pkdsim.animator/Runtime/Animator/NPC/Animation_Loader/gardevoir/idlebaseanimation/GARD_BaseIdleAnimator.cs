using project_pkdsim.ANIMATOR.NPC.Gardevoir.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Gardevoir.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Gardevoir.idlebaseanimation
{
	public class Gardevoir_IdleAnimatorController : MonoBehaviour 
	{
		private GARDIdleStanding Gardevoiridlestanding;
		
		private GARD_IdleSitting Gardevoiridlesitting;
		
		public void	GARD_IdleAnimatorController()
		{
			GARDIdleStandingAnimatorController();
			GARD_IdleSittingAnimatorController();
		}
		private void GARDIdleStandingAnimatorController()
		{
			Gardevoiridlestanding.GARDIdleStandingController();
		}
		private void GARD_IdleSittingAnimatorController()
		{
			Gardevoiridlesitting.GARD_IdleSittingController();
		}
	}
}