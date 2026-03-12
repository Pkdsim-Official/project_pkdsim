using Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Turning
{
	public class BLParentMom_Turning : MonoBehaviour	
	{
		private BLParentMom_TurnLeft BLParentMom_TurnLeft;
		private BLParentMom_TurnRight BLParentMom_TurnRight;

		public void BLParentMom_TurningController()
		{
			if (BLParentMom_TurnLeft != null)
			{
				
				Load_BLParentMom_TurnLeft();
			}

			if (BLParentMom_TurnRight != null)
			{
				Load_BLParentMom_TurnRight();
			}
			
		}
		private void Load_BLParentMom_TurnRight()
		{
			BLParentMom_TurnRight.BLParentMom_TurnRightController();
		}
		
		private void Load_BLParentMom_TurnLeft()
		{
			BLParentMom_TurnLeft.BLParentMom_TurnLeftController();
		}
	}
}