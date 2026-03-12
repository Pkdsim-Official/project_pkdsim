using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Dragapult.idlebaseanimation
{
	public class Dragapult_IdleAnimatorController : MonoBehaviour 
	{
		private DRIdleStanding Dragapultidlestanding;
		
		private DR_IdleSitting Dragapultidlesitting;
		
		public void	DR_IdleAnimatorController()
		{
			DRIdleStandingAnimatorController();
			DR_IdleSittingAnimatorController();
		}
		private void DRIdleStandingAnimatorController()
		{
			Dragapultidlestanding.DRIdleStandingController();
		}
		private void DR_IdleSittingAnimatorController()
		{
			Dragapultidlesitting.DR_IdleSittingController();
		}
	}
}