using project_pkdsim.ANIMATOR.Parents.Lunala.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Lunala.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Dad.idlebaseanimation
{
	public class Lunala_IdleAnimatorController : MonoBehaviour 
	{
		private LUNAIdleStanding Lunalaidlestanding;
		
		private LUNAIdleSitting Lunalaidlesitting;
		
		public void	LUNA_IdleAnimatorController()
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