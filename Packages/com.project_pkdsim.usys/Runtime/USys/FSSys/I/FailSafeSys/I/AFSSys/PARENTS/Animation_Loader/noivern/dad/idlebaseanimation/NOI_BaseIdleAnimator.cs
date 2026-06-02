using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.idlebaseanimation
{
	public class NoivernParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private NOIIdleStanding Noivernidlestanding;
		
		private NOIIdleSitting Noivernidlesitting;
		
		public void	NOI_IdleAnimatorController()
		{
			NOIIdleStandingAnimatorController();
			NOIIdleSittingAnimatorController();
		}
		private void NOIIdleStandingAnimatorController()
		{
			Noivernidlestanding.NOIIdleStandingController();
		}
		private void NOIIdleSittingAnimatorController()
		{
			Noivernidlesitting.NOIIdleSittingController();
		}
	}
}