using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Beedrill.movementbasedanimations.Strafing
{
	public class BE_Strafing : MonoBehaviour 
	{
		private BE_StrafeLeft BE_strafeleft;
		
		private BE_StrafeRight BE_straferight;

		public void BE_StrafingController()
		{
			if (BE_strafeleft == null)
			{
				Load_BEStrafeLeft();
			}
			if (BE_straferight == null)
			{
				Load_BEStrafeRight();
			}
			

		}
		private void Load_BEStrafeRight()
		{
			BE_straferight.BE_StrafeRightController();
		}
		
		private void Load_BEStrafeLeft()
		{
			BE_strafeleft.BE_StrafeLeftController();
		}
	}
}