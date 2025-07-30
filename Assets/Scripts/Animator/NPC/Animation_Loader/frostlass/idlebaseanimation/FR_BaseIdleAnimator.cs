using project_pkdsim.ANIMATOR.NPC.Frostlass.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Frostlass.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Frostlass.idlebaseanimation
{
	public class Frostlass_IdleAnimatorController : MonoBehaviour 
	{
		private FRIdleStanding Frostlassidlestanding;
		
		private FR_IdleSitting Frostlassidlesitting;
		
		public void	FR_IdleAnimatorController()
		{
			FRIdleStandingAnimatorController();
			FR_IdleSittingAnimatorController();
		}
		private void FRIdleStandingAnimatorController()
		{
			Frostlassidlestanding.FRIdleStandingController();
		}
		private void FR_IdleSittingAnimatorController()
		{
			Frostlassidlesitting.FR_IdleSittingController();
		}
	}
}