using project_pkdsim.ANIMATOR.Parents.Frostlass.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Frostlass.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.idlebaseanimation
{
	public class Frostlass_IdleAnimatorController : MonoBehaviour 
	{
		private FRIdleStanding Frostlassidlestanding;
		
		private FRIdleSitting Frostlassidlesitting;
		
		public void	FR_IdleAnimatorController()
		{
			FRIdleStandingAnimatorController();
			FRIdleSittingAnimatorController();
		}
		private void FRIdleStandingAnimatorController()
		{
			Frostlassidlestanding.FRIdleStandingController();
		}
		private void FRIdleSittingAnimatorController()
		{
			Frostlassidlesitting.FRIdleSittingController();
		}
	}
}