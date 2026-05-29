using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;
namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Turning
{
	public class GLParent_Turning : MonoBehaviour	
	{
		private GLParent_TurnLeft GLParent_TurnLeft;
		private GLParent_TurnRight GLParent_TurnRight;

		public void GLParent_TurningController()
		{
			if (GLParent_TurnLeft == null)
			{
				GLParent_TurnLeft = GetComponent<GLParent_TurnLeft>();
				Load_GLParent_TurnLeft();
			}
			if (GLParent_TurnRight == null)
			{
				GLParent_TurnRight = GetComponent<GLParent_TurnRight>();
				Load_GLParent_TurnRight();
			}
			

		}
		private void Load_GLParent_TurnRight()
		{
			GLParent_TurnRight.GLParent_TurnRightController();
		}
		
		private void Load_GLParent_TurnLeft()
		{
			GLParent_TurnLeft.GLParent_TurnLeftController();
		}
	}
}