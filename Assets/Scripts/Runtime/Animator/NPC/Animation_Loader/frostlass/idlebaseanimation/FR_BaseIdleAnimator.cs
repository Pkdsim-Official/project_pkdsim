using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Frostlass.idlebaseanimation
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