using project_pkdsim.ANIMATOR.Player.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Player.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Player.movementbasedanimations.Strafing
{
	public class Player_Strafing : MonoBehaviour 
	{
		private Player_StrafeLeft Player_strafeleft;
		
		private Player_StrafeRight Player_straferight;

		public void Player_StrafingController()
		{
			if (Player_strafeleft == null)
			{
				Load_Player_StrafeLeft();
			}
			if (Player_straferight == null)
			{
				Load_Player_StrafeRight();
			}
			

		}
		private void Load_Player_StrafeRight()
		{
			Player_straferight.Player_StrafeRightController();
		}
		
		private void Load_Player_StrafeLeft()
		{
			Player_strafeleft.Player_StrafeLeftController();
		}
	}
}