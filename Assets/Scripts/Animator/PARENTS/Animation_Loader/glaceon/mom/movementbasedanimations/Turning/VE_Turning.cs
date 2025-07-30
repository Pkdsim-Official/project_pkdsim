using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Turning
{
	public class GLParentMom_Turning : MonoBehaviour	
	{
		private GLParentMom_TurnLeft GLParentMom_TurnLeft;
		private GLParentMom_TurnRight GLParentMom_TurnRight;

		public void GLParentMom_TurningController()
		{
			if (GLParentMom_TurnLeft != null)
			{
				
				Load_GLParentMom_TurnLeft();
			}

			if (GLParentMom_TurnRight != null)
			{
				Load_GLParentMom_TurnRight();
			}
			
		}
		private void Load_GLParentMom_TurnRight()
		{
			GLParentMom_TurnRight.GLParentMom_TurnRightController();
		}
		
		private void Load_GLParentMom_TurnLeft()
		{
			GLParentMom_TurnLeft.GLParentMom_TurnLeftController();
		}
	}
}