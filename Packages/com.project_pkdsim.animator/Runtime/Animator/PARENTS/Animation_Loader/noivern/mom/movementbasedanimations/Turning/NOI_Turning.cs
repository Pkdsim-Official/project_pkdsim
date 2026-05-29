using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Turning
{
	public class NOIParent_Turning : MonoBehaviour	
	{
		private NOIParent_TurnLeft NOIParent_TurnLeft;
		private NOIParent_TurnRight NOIParent_TurnRight;

		public void NOIParent_TurningController()
		{
			if (NOIParent_TurnLeft == null)
			{
				Load_NOIParent_TurnLeft();
			}

			if (NOIParent_TurnRight == null)
			{
				Load_NOIParent_TurnRight();
			}
		}

		private void Load_NOIParent_TurnRight()
		{
			NOIParent_TurnRight.NOIParent_TurnRightController();
		}
		
		private void Load_NOIParent_TurnLeft()
		{
			NOIParent_TurnLeft.NOIParent_TurnLeftController();
		}
	}
}