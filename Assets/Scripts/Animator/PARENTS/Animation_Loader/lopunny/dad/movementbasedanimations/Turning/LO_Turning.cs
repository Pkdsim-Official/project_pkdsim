using project_pkdsim.ANIMATOR.Parents.Lopunny.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Lopunny.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.movementbasedanimations.Turning
{
	public class LOParent_Turning : MonoBehaviour	
	{
		private LOParent_TurnLeft LOParent_TurnLeft;
		private LOParent_TurnRight LOParent_TurnRight;

		public void LOParent_TurningController()
		{
			if (LOParent_TurnLeft == null)
			{
				Load_LOParent_TurnLeft();
			}

			if (LOParent_TurnRight == null)
			{
				Load_LOParent_TurnRight();
			}
			
		}
		private void Load_LOParent_TurnRight()
		{
			LOParent_TurnRight.LOParent_TurnRightController();
		}
		
		private void Load_LOParent_TurnLeft()
		{
			LOParent_TurnLeft.LOParent_TurnLeftController();
		}
	}
}