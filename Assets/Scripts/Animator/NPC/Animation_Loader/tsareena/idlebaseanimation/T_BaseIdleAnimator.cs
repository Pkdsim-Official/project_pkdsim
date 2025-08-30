using project_pkdsim.Models.ANIMATOR.NPC.Tsareena.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Tsareena.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Tsareena.idlebaseanimation
{
	public class TsareenaIdleAnimatorController : MonoBehaviour 
	{
		private TIdleStanding Tidlestanding;
		
		private TIdleSitting Tidlesitting;
		
		public void	TIdleAnimatorController()
		{
			TIdleStandingAnimatorController();
			TIdleSittingAnimatorController();
		}
		private void TIdleStandingAnimatorController()
		{
			Tidlestanding.TIdleStandingController();
		}
		private void TIdleSittingAnimatorController()
		{
			Tidlesitting.TIdleSittingController();
		}
	}
}