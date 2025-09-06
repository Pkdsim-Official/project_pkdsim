using project_pkdsim.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Turning
{
	public class PH_Turning : MonoBehaviour	
	{
		private PH_TurnLeft PH_turnleft;
		private PH_TurnRight PH_turnright;

		public void PH_TurningController()
		{
			if (PH_turnleft != null)
			{
				Load_PH_turnLeft();
			}
			
			if (PH_turnright != null)
			{
				Load_PH_turnRight();
			}
			

		}
		private void Load_PH_turnRight()
		{
			PH_turnright.PH_TurnRightController();
		}
		
		private void Load_PH_turnLeft()
		{
			PH_turnleft.PH_TurnLeftController();
		}
	}
}