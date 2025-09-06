using project_pkdsim.ANIMATOR.Player.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Player.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Player.idlebaseanimation
{
	public class PlayerIdleAnimatorController : MonoBehaviour 
	{
		private Player_IdleStanding PlayerIdlestanding;
		
		private Player_IdleSitting PlayerIdlesitting;
		
		public void	Player_IdleAnimatorController()
		{
			Player_IdleStandingAnimatorController();
			Player_IdleSittingAnimatorController();
		}
		private void Player_IdleStandingAnimatorController()
		{
			PlayerIdlestanding.Player_IdleStandingController();
		}
		private void Player_IdleSittingAnimatorController()
		{
			PlayerIdlesitting.Player_IdleSittingController();
		}
	}
}