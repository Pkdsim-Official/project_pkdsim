using project_pkdsim.ANIMATOR.Player.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Player.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Player.idlebaseanimation
{
	public class Player_IdleAnimatorController : MonoBehaviour 
	{
		private Player_IdleStanding PlayerIdlestanding;
		
		private Player_IdleSitting PlayerIdlesitting;
		
		public void	PL_IdleAnimatorController()
		{
			PL_IdleStandingAnimatorController();
			PL_IdleSittingAnimatorController();
		}
		private void PL_IdleStandingAnimatorController()
		{
			PlayerIdlestanding.Player_IdleStandingController();
		}
		private void PL_IdleSittingAnimatorController()
		{
			PlayerIdlesitting.Player_IdleSittingController();
		}
	}
}