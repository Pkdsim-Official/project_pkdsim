using project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Turning
{
	public class LEParentMom_Turning : MonoBehaviour	
	{
		private LEParentMom_TurnLeft LEParentMom_TurnLeft;
		private LEParentMom_TurnRight LEParentMom_TurnRight;

		public void LEParentMom_TurningController()
		{
			if (LEParentMom_TurnLeft != null)
			{
				
				Load_LEParentMom_TurnLeft();
			}

			if (LEParentMom_TurnRight != null)
			{
				Load_LEParentMom_TurnRight();
			}
			
		}
		private void Load_LEParentMom_TurnRight()
		{
			LEParentMom_TurnRight.LEParentMom_TurnRightController();
		}
		
		private void Load_LEParentMom_TurnLeft()
		{
			LEParentMom_TurnLeft.LEParentMom_TurnLeftController();
		}
	}
}