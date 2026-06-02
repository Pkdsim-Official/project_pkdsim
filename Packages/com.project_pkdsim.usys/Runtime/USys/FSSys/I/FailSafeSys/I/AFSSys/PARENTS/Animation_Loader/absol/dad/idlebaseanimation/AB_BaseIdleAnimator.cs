using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation
{
	public class AbsolParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private ABIdleStanding Absolidlestanding;
		
		private ABIdleSitting Absolidlesitting;
		
		public void	AB_IdleAnimatorController()
		{
			ABIdleStandingAnimatorController();
			ABIdleSittingAnimatorController();
		}
		public void ABIdleStandingAnimatorController()
		{
			Absolidlestanding.ABIdleStandingController();
		}
		public void ABIdleSittingAnimatorController()
		{
			Absolidlesitting.ABIdleSittingController();
		}
	}
}