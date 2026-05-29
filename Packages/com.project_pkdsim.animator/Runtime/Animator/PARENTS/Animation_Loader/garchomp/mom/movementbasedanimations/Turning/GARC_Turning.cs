using project_pkdsim.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Turning
{
	public class GARCParent_Turning : MonoBehaviour	
	{
		private GARCParent_TurnLeft GARCParent_TurnLeft;
		private GARCParent_TurnRight GARCParent_TurnRight;

		public void GARCParent_TurningController()
		{
			if (GARCParent_TurnLeft == null)
			{
				Load_GARCParent_TurnLeft();
			}
			if (GARCParent_TurnRight == null)
			{
				Load_GARCParent_TurnRight();
			}
		}

		private void Load_GARCParent_TurnRight()
		{
			GARCParent_TurnRight.GARCParent_TurnRightController();
		}
		
		private void Load_GARCParent_TurnLeft()
		{
			GARCParent_TurnLeft.GARCParent_TurnLeftController();
		}
	}
}