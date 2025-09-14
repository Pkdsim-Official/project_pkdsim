using project_pkdsim.ANIMATOR.Npcs.Glaceon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Npcs.Glaceon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;
namespace project_pkdsim.ANIMATOR.Npcs.Glaceon.movementbasedanimations.Turning
{
	public class GL_Turning : MonoBehaviour	
	{
		private GL_TurnLeft GL_turnleft;
		private GL_TurnRight GL_turnright;

		public void GL_TurningController()
		{
			if (GL_turnleft == null)
			{
				GL_turnleft = GetComponent<GL_TurnLeft>();
				Load_GL_turnLeft();
			}
			if (GL_turnright == null)
			{
				GL_turnright = GetComponent<GL_TurnRight>();
				Load_GL_turnRight();
			}
			

		}
		private void Load_GL_turnRight()
		{
			GL_turnright.GL_TurnRightController();
		}
		
		private void Load_GL_turnLeft()
		{
			GL_turnleft.GL_TurnLeftController();
		}
	}
}