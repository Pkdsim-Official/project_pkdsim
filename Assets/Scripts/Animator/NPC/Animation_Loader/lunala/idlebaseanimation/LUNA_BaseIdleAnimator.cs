using project_pkdsim.Models.ANIMATOR.NPC.Lunala.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Lunala.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Lunala.idlebaseanimation
{
	public class LunalaIdleAnimatorController : MonoBehaviour 
	{
		private LUNAIdleStanding Lunalaidlestanding;
		
		private LUNAIdleSitting Lunalaidlesitting;
		
		public void	LUNAIdleAnimatorController()
		{
			LUNAIdleStandingAnimatorController();
			LUNAIdleSittingAnimatorController();
		}
		private void LUNAIdleStandingAnimatorController()
		{
			Lunalaidlestanding.LUNAIdleStandingController();
		}
		private void LUNAIdleSittingAnimatorController()
		{
			Lunalaidlesitting.LUNAIdleSittingController();
		}
	}
}