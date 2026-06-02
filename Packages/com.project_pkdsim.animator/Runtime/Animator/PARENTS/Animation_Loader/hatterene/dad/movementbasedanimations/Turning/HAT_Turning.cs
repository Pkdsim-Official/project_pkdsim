using project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations.Turning
{
	public class HAT_Parent_Turning : MonoBehaviour	
	{
		private HAT_Parent_TurnLeft HAT_Parent_TurnLeft;
		private HAT_Parent_TurnRight HAT_Parent_TurnRight;

		public void HAT_Parent_TurningController()
		{
			if (HAT_Parent_TurnLeft == null)
			{
				Load_HAT_Parent_TurnLeft();
			}
			if (HAT_Parent_TurnRight == null)
			{
				Load_HAT_Parent_TurnRight();
			}
		}

		private void Load_HAT_Parent_TurnRight()
		{
			HAT_Parent_TurnRight.HAT_Parent_TurnRightController();
		}
		
		private void Load_HAT_Parent_TurnLeft()
		{
			HAT_Parent_TurnLeft.HAT_Parent_TurnLeftController();
		}
	}
}