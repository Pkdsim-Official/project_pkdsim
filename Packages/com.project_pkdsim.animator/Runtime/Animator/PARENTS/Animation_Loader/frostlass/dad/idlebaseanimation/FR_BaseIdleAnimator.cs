using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadidlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadidlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadidlebaseanimation
{
	public class FrostlassParentDad_IdleAnimatorController : MonoBehaviour 
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