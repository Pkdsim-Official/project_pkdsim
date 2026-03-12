using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.idlebaseanimation
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