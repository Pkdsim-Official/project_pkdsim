using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.idlebaseanimation
{
	public class Garchomp_IdleAnimatorController : MonoBehaviour 
	{
		private GARC_IdleStanding Garchompidlestanding;
		
		private GARC_IdleSitting Garchompidlesitting;
		
		public void	GARC_IdleAnimatorController()
		{
			GARC_IdleStandingAnimatorController();
			GARC_IdleSittingAnimatorController();
		}
		private void GARC_IdleStandingAnimatorController()
		{
			Garchompidlestanding.GARC_IdleStandingController();
		}
		private void GARC_IdleSittingAnimatorController()
		{
			Garchompidlesitting.GARC_IdleSittingController();
		}
	}
}