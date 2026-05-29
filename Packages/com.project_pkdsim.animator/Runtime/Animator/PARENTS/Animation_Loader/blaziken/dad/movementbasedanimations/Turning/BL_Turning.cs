using project_pkdsim.ANIMATOR.Parents.Blaziken.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Blaziken.Dad.movementbasedanimations.Turning
{
	public class BLParent_Turning : MonoBehaviour	
	{
		private BLParent_TurnLeft BLParent_TurnLeft;
		private BLParent_TurnRight BLParent_TurnRight;

		public void BLParent_TurningController()
		{
			if (BLParent_TurnLeft == null)
			{
				Load_BLParent_TurnLeft();
			}
			if (BLParent_TurnRight == null)
			{
				Load_BLParent_TurnRight();
			}
		}

		private void Load_BLParent_TurnRight()
		{
			BLParent_TurnRight.BLParent_TurnRightController();
		}
		
		private void Load_BLParent_TurnLeft()
		{
			BLParent_TurnLeft.BLParent_TurnLeftController();
		}
	}
}