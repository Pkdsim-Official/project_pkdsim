using project_pkdsim.ANIMATOR.NPC.Primarina.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.NPC.Primarina.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Primarina.movementbasedanimations.Turning
{
	public class PR_Turning : MonoBehaviour	
	{
		private PR_TurnLeft PR_turnleft;
		private PR_TurnRight PR_turnright;

		public void PR_TurningController()
		{
			if (PR_turnleft != null)
			{
				Load_PR_turnLeft();
			}

			if (PR_turnright != null)
			{
				Load_PR_turnRight();
			}
			
		}
		private void Load_PR_turnRight()
		{
			PR_turnright.PR_TurnRightController();
		}
		
		private void Load_PR_turnLeft()
		{
			PR_turnleft.PR_TurnLeftController();
		}
	}
}