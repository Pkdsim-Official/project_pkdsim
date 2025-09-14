using project_pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Turning
{
	public class ABParentMom_Turning : MonoBehaviour	
	{
		private ABParentMom_TurnLeft ABParentMom_TurnLeft;
		private ABParentMom_TurnRight ABParentMom_TurnRight;

		public void ABParentMom_TurningController()
		{
			if (ABParentMom_TurnLeft != null)
			{
				
				Load_ABParentMom_TurnLeft();
			}

			if (ABParentMom_TurnRight != null)
			{
				Load_ABParentMom_TurnRight();
			}
			
		}
		private void Load_ABParentMom_TurnRight()
		{
			ABParentMom_TurnRight.ABParentMom_TurnRightController();
		}
		
		private void Load_ABParentMom_TurnLeft()
		{
			ABParentMom_TurnLeft.ABParentMom_TurnLeftController();
		}
	}
}