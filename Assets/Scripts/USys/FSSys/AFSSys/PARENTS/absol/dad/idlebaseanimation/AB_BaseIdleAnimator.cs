using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation
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