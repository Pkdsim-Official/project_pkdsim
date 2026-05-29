using project_pkdsim.ANIMATOR.Parents.Absol.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Absol.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Mom.idlebaseanimation
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