using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation
{
	public class Absol_IdleAnimatorController : MonoBehaviour 
	{
		private ABIdleStanding Absolidlestanding;
		
		private ABIdleSitting Absolidlesitting;
		
		public void	AB_IdleAnimatorController()
		{
			ABIdleStandingAnimatorController();
			ABIdleSittingAnimatorController();
		}
		private void ABIdleStandingAnimatorController()
		{
			Absolidlestanding.ABIdleStandingController();
		}
		private void ABIdleSittingAnimatorController()
		{
			Absolidlesitting.ABIdleSittingController();
		}
	}
}