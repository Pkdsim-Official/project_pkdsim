using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.Dad.movementbasedanimations.Turning
{
	public class PRParent_Turning : MonoBehaviour	
	{
		private PRParent_TurnLeft PRParent_TurnLeft;
		private PRParent_TurnRight PRParent_TurnRight;

		public void PRParent_TurningController()
		{
			if (PRParent_TurnLeft != null)
			{
				Load_PRParent_TurnLeft();
			}

			if (PRParent_TurnRight != null)
			{
				Load_PRParent_TurnRight();
			}
			
		}
		private void Load_PRParent_TurnRight()
		{
			PRParent_TurnRight.PRParent_TurnRightController();
		}
		
		private void Load_PRParent_TurnLeft()
		{
			PRParent_TurnLeft.PRParent_TurnLeftController();
		}
	}
}