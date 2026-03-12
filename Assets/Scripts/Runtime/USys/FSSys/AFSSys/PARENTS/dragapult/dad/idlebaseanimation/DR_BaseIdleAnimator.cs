using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.idlebaseanimation
{
	public class Dragapult_IdleAnimatorController : MonoBehaviour 
	{
		private DRIdleStanding Dragapultidlestanding;
		
		private DRIdleSitting Dragapultidlesitting;
		
		public void	DR_IdleAnimatorController()
		{
			DRIdleStandingAnimatorController();
			DRIdleSittingAnimatorController();
		}
		private void DRIdleStandingAnimatorController()
		{
			Dragapultidlestanding.DRIdleStandingController();
		}
		private void DRIdleSittingAnimatorController()
		{
			Dragapultidlesitting.DRIdleSittingController();
		}
	}
}