using project_pkdsim.ANIMATOR.NPC.Delphox.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Delphox.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Delphox.idlebaseanimation
{
	public class DelphoxIdleAnimatorController : MonoBehaviour 
	{
		private DLIdleStanding DLidlestanding;
		
		private DLIdleSitting DLidlesitting;
		
		public void	DLIdleAnimatorController()
		{
			DLIdleStandingAnimatorController();
			DLIdleSittingAnimatorController();
		}
		private void DLIdleStandingAnimatorController()
		{
			DLidlestanding.DLIdleStandingController();
		}
		private void DLIdleSittingAnimatorController()
		{
			DLidlesitting.DLIdleSittingController();
		}
	}
}