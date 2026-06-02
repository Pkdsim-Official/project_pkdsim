using project_pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Turning
{
	public class MEOW_Parent_Turning : MonoBehaviour	
	{
		private MEOW_Parent_TurnLeft MEOW_Parent_TurnLeft;
		private MEOW_Parent_TurnRight MEOW_Parent_TurnRight;

		public void MEOW_Parent_TurningController()
		{
			if (MEOW_Parent_TurnLeft == null)
			{
				Load_MEOW_Parent_TurnLeft();
			}
			if (MEOW_Parent_TurnRight == null)
			{
				Load_MEOW_Parent_TurnRight();
			}
		}

		private void Load_MEOW_Parent_TurnRight()
		{
			MEOW_Parent_TurnRight.MEOW_Parent_TurnRightController();
		}
		
		private void Load_MEOW_Parent_TurnLeft()
		{
			MEOW_Parent_TurnLeft.MEOW_Parent_TurnLeftController();
		}
	}
}