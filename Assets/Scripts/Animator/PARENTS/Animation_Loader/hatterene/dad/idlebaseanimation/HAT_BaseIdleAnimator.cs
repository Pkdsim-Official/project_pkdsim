using project_pkdsim.ANIMATOR.Parents.Hatterene.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Hatterene.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.idlebaseanimation
{
	public class Hatterene_IdleAnimatorController : MonoBehaviour 
	{
		private HATIdleStanding HATidlestanding;
		
		private HATIdleSitting HATidlesitting;
		
		public void	HAT_IdleAnimatorController()
		{
			HATIdleStandingAnimatorController();
			HATIdleSittingAnimatorController();
		}
		private void HATIdleStandingAnimatorController()
		{
			HATidlestanding.HATIdleStandingController();
		}
		private void HATIdleSittingAnimatorController()
		{
			HATidlesitting.HATIdleSittingController();
		}
	}
}