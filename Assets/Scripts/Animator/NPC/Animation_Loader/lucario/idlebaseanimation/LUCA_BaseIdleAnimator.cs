using project_pkdsim.ANIMATOR.NPC.Lucario.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Lucario.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lucario.idlebaseanimation
{
	public class Lucario_IdleAnimatorController : MonoBehaviour 
	{
		private LUCAIdleStanding LucarioIdleStanding;
		
		private LUCA_IdleSitting Lucario_IdleSitting;
		
		public void	LUCA_IdleAnimatorController()
		{
			LUCAIdleStandingAnimatorController();
			LUCA_IdleSittingAnimatorController();
		}
		private void LUCAIdleStandingAnimatorController()
		{
			LucarioIdleStanding.LUCAIdleStandingController();
		}
		private void LUCA_IdleSittingAnimatorController()
		{
			Lucario_IdleSitting.LUCA_IdleSittingController();
		}
	}
}