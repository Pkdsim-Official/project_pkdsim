using Project_Pkdsim.ANIMATOR.Player.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Player.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Player.converteranimations.SittingTo
{
	public class Player_SittingTo : MonoBehaviour 
	{
		private Player_SittingToStartWalking Player_SittingToStartWalking;
		private Player_SittingToStanding Player_SittingToStanding;
		public void Player_SittingToController()
		{
			Pl_SittingToStartWalking();
			Pl_SittingToStanding();
		}
		private void Pl_SittingToStartWalking()
		{
			Player_SittingToStartWalking.Player_SittingToStartWalkingController();
		}
		private void Pl_SittingToStanding()
		{
			Player_SittingToStanding.Player_SittingToStandingController();
		}
	}
}