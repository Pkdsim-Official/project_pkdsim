using Project_Pkdsim.ANIMATOR.Player.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Player.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Player.converteranimations.IdleTo
{
	public class Player_IdleTo : MonoBehaviour 
	{
		private Player_IdleToRun PlayerIdleToRun;
		private Player_IdleToWalk PlayerIdleToWalk;

		public void Player_IdleToController()
		{
			Load_Player_IdleToRun();
			Load_Player_IdleToWalk();
		}
		private void Load_Player_IdleToRun()
		{
			PlayerIdleToRun.Player_IdleToRunController();
		}
		private void Load_Player_IdleToWalk()
		{
			PlayerIdleToWalk.Player_IdleToWalkController();
		}
	}
}