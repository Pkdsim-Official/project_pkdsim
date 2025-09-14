using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Turning
{
	public class SYLParentMom_Turning : MonoBehaviour	
	{
		private SYLParentMom_TurnLeft SYLParentMom_TurnLeft;
		private SYLParentMom_TurnRight SYLParentMom_TurnRight;

		public void SYLParentMom_TurningController()
		{
			if (SYLParentMom_TurnLeft != null)
			{
				
				Load_SYLParentMom_TurnLeft();
			}

			if (SYLParentMom_TurnRight != null)
			{
				Load_SYLParentMom_TurnRight();
			}
			
		}
		private void Load_SYLParentMom_TurnRight()
		{
			SYLParentMom_TurnRight.SYLParentMom_TurnRightController();
		}
		
		private void Load_SYLParentMom_TurnLeft()
		{
			SYLParentMom_TurnLeft.SYLParentMom_TurnLeftController();
		}
	}
}