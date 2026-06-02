using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation
{
	public class GardevoirParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private GARDIdleStanding Gardevoiridlestanding;
		
		private GARDIdleSitting Gardevoiridlesitting;
		
		public void	GARD_IdleAnimatorController()
		{
			GARDIdleStandingAnimatorController();
			GARDIdleSittingAnimatorController();
		}
		private void GARDIdleStandingAnimatorController()
		{
			Gardevoiridlestanding.GARDIdleStandingController();
		}
		private void GARDIdleSittingAnimatorController()
		{
			Gardevoiridlesitting.GARDIdleSittingController();
		}
	}
}