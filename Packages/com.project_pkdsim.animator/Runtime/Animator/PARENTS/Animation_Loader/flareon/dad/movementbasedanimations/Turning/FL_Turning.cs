using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations.Turning
{
	public class FLParent_Turning : MonoBehaviour	
	{
		private FLParent_TurnLeft FLParent_TurnLeft;
		private FLParent_TurnRight FLParent_TurnRight;

		public void FLParent_TurningController()
		{
			if (FLParent_TurnLeft == null)
			{
				Load_FLParent_TurnLeft();
			}
			if (FLParent_TurnRight == null)
			{
				Load_FLParent_TurnRight();
			}
		}

		private void Load_FLParent_TurnRight()
		{
			FLParent_TurnRight.FLParent_TurnRightController();
		}
		
		private void Load_FLParent_TurnLeft()
		{
			FLParent_TurnLeft.FLParent_TurnLeftController();
		}
	}
}