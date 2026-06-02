using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Turning
{
	public class GLParentMom_Turning : MonoBehaviour	
	{
		private GLParentMom_TurnLeft GLParentMom_TurnLeft;
		private GLParentMom_TurnRight GLParentMom_TurnRight;

		public void GLParentMom_TurningController()
		{
			if (GLParentMom_TurnLeft == null)
			{
				GLParentMom_TurnLeft = GetComponent<GLParentMom_TurnLeft>();
				Load_GLParentMom_TurnLeft();
			}
			if (GLParentMom_TurnRight == null)
			{
				GLParentMom_TurnRight = GetComponent<GLParentMom_TurnRight>();
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