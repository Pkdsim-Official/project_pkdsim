using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Turning
{
	public class SYLParent_Turning : MonoBehaviour 
	{
		private SYLParent_TurnLeft SYLParent_TurnLeft;
		private SYLParent_TurnRight SYLParent_TurnRight;

		public void SYLParent_TurningController()
		{
			if (SYLParent_TurnLeft == null)
			{
				Load_SYLParent_TurnLeft();
			}
			if (SYLParent_TurnRight == null)
			{
				Load_SYLParent_TurnRight();
			}
		}

		private void Load_SYLParent_TurnRight()
		{
			SYLParent_TurnRight.SYLParent_TurnRightController();
		}
		
		private void Load_SYLParent_TurnLeft()
		{
			SYLParent_TurnLeft.SYLParent_TurnLeftController();
		}

	}
}