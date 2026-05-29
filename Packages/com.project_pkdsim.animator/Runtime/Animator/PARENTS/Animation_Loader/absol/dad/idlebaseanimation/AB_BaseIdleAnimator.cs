using project_pkdsim.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Dad.idlebaseanimation
{
	public class AbsolParent_IdleAnimatorController : MonoBehaviour 
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