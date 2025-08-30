using project_pkdsim.Models.ANIMATOR.NPC.Blaziken.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Blaziken.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Blaziken.idlebaseanimation
{
	public class BlazikenIdleAnimatorController : MonoBehaviour 
	{
		private BLIdleStanding BLidlestanding;
		
		private BLIdleSitting BLidlesitting;
		
		public void	BLIdleAnimatorController()
		{
			BLIdleStandingAnimatorController();
			BLIdleSittingAnimatorController();
		}
		private void BLIdleStandingAnimatorController()
		{
			BLidlestanding.BLIdleStandingController();
		}
		private void BLIdleSittingAnimatorController()
		{
			BLidlesitting.BLIdleSittingController();
		}
	}
}