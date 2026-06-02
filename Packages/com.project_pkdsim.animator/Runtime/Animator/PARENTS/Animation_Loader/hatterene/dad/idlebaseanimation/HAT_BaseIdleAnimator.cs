using project_pkdsim.ANIMATOR.Parents.Hatterene.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Hatterene.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.idlebaseanimation
{
	public class Hatterene_IdleAnimatorController : MonoBehaviour 
	{
		private HAT_IdleStanding HAT_idlestanding;
		
		private HAT_IdleSitting HAT_idlesitting;
		
		public void	HAT_IdleAnimatorController()
		{
			HAT_IdleStandingAnimatorController();
			HAT_IdleSittingAnimatorController();
		}
		private void HAT_IdleStandingAnimatorController()
		{
			HAT_idlestanding.HAT_IdleStandingController();
		}
		private void HAT_IdleSittingAnimatorController()
		{
			HAT_idlesitting.HAT_IdleSittingController();
		}
	}
}