using project_pkdsim.Models.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Turning
{
	public class VE_Turning : MonoBehaviour	
	{
		private VE_TurnLeft VE_turnleft;
		private VE_TurnRight VE_turnright;

		public void VE_TurningController()
		{
			if (VE_turnleft != null)
			{
				
				Load_Ve_turnLeft();
			}

			if (VE_turnright != null)
			{
				Load_Ve_turnRight();
			}
			
		}
		private void Load_Ve_turnRight()
		{
			VE_turnright.VE_TurnRightController();
		}
		
		private void Load_Ve_turnLeft()
		{
			VE_turnleft.VE_TurnLeftController();
		}
	}
}