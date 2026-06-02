using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.idlebaseanimation
{
	public class PheromosaParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private PHIdleStanding PHidlestanding;
		
		private PHIdleSitting PHidlesitting;
		
		public void	PH_IdleAnimatorController()
		{
			PHIdleStandingAnimatorController();
			PHIdleSittingAnimatorController();
		}
		private void PHIdleStandingAnimatorController()
		{
			PHidlestanding.PHIdleStandingController();
		}
		private void PHIdleSittingAnimatorController()
		{
			PHidlesitting.PHIdleSittingController();
		}
	}
}