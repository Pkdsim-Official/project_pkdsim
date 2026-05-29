using project_pkdsim.ANIMATOR.Parents.Lunala.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Lunala.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Dad.movementbasedanimations.Turning
{
	public class LUNAParent_Turning : MonoBehaviour	
	{
		private LUNAParent_TurnLeft LUNAParent_TurnLeft;
		private LUNAParent_TurnRight LUNAParent_TurnRight;

		public void LUNAParent_TurningController()
		{
			if (LUNAParent_TurnLeft == null)
			{
				Load_LUNAParent_TurnLeft();
			}

			if (LUNAParent_TurnRight == null)
			{
				Load_LUNAParent_TurnRight();
			}
		}

		private void Load_LUNAParent_TurnRight()
		{
			LUNAParent_TurnRight.LUNAParent_TurnRightController();
		}
		
		private void Load_LUNAParent_TurnLeft()
		{
			LUNAParent_TurnLeft.LUNAParent_TurnLeftController();
		}
	}
}