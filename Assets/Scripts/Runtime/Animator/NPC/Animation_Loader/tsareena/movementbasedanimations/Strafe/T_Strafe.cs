using Project_Pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations.Strafing
{
	public class T_Strafing : MonoBehaviour 
	{
		private T_StrafeLeft T_strafeleft;
		
		private T_StrafeRight T_straferight;

		public void T_StrafingController()
		{
			if (T_strafeleft == null)
			{
				Load_T_StrafeLeft();
			}
			if (T_straferight == null)
			{
				Load_T_StrafeRight();
			}
			

		}
		private void Load_T_StrafeRight()
		{
			T_straferight.T_StrafeRightController();
		}
		
		private void Load_T_StrafeLeft()
		{
			T_strafeleft.T_StrafeLeftController();
		}
	}
}