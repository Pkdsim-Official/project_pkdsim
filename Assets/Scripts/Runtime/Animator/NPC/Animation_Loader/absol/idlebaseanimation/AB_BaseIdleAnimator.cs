using Project_Pkdsim.ANIMATOR.Npcs.Absol.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Absol.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Absol.idlebaseanimation
{
	public class Absol_IdleAnimatorController : MonoBehaviour 
	{
		private ABIdleStanding AbsolIdlestanding;
		
		private AB_IdleSitting AbsolIdlesitting;
		
		public void	AB_IdleAnimatorController()
		{
			AB_IdleStandingAnimatorController();
			AB_IdleSittingAnimatorController();
		}
		private void AB_IdleStandingAnimatorController()
		{
			AbsolIdlestanding.ABIdleStandingController();
		}
		private void AB_IdleSittingAnimatorController()
		{
			AbsolIdlesitting.AB_IdleSittingController();
		}
	}
}