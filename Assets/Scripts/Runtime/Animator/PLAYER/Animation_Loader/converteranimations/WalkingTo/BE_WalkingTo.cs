using Project_Pkdsim.ANIMATOR.Player.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Player.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Player.converteranimations.WalkingTo
{
	public class Player_WalkingTo : MonoBehaviour 
	{
		private Player_WalkingToStanding Player_WalkingToStanding;
		private Player_WalkingToSitting Player_WalkingToSitting;
		public void Player_WalkingToController()
		{
			Load_Player_WalkingToStanding();
			Load_Player_WalkingToWSitting();
		}
		private void Load_Player_WalkingToStanding()
		{
			Player_WalkingToStanding.Player_WalkingToStandingController();
		}
		private void Load_Player_WalkingToWSitting()
		{
			Player_WalkingToSitting.Player_WalkingToSittingController();
		}
	}
}