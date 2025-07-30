using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Turning
{
	public class GLParentDad_Turning : MonoBehaviour
	{
		private GLParentDad_TurnLeft GLParentDad_TurnLeft;
		private GLParentDad_TurnRight GLParentDad_TurnRight;

		public void GLParentDad_TurningController()
		{
			if (GLParentDad_TurnLeft == null)
			{
				GLParentDad_TurnLeft = GetComponent<GLParentDad_TurnLeft>();
				Load_GLParentDad_TurnLeft();
			}
			if (GLParentDad_TurnRight == null)
			{
				GLParentDad_TurnRight = GetComponent<GLParentDad_TurnRight>();
				Load_GLParentDad_TurnRight();
			}


		}
		private void Load_GLParentDad_TurnRight()
		{
			GLParentDad_TurnRight.GLParentDad_TurnRightController();
		}

		private void Load_GLParentDad_TurnLeft()
		{
			GLParentDad_TurnLeft.GLParentDad_TurnLeftController();
		}
	}
}