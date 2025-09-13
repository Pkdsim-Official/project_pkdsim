using project_pkdsim.ANIMATOR.Parents.Lucario.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Lucario.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.idlebaseanimation
{
	public class Lucario_IdleAnimatorController : MonoBehaviour 
	{
		private LUCAIdleStanding LucarioIdleStanding;
		
		private LUCAIdleSitting LucarioIdleSitting;
		
		public void	LUCA_IdleAnimatorController()
		{
			LUCAIdleStandingAnimatorController();
			LUCAIdleSittingAnimatorController();
		}
		private void LUCAIdleStandingAnimatorController()
		{
			LucarioIdleStanding.LUCAIdleStandingController();
		}
		private void LUCAIdleSittingAnimatorController()
		{
			LucarioIdleSitting.LUCAIdleSittingController();
		}
	}
}