using project_pkdsim.ANIMATOR.Parents.Jolteon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Jolteon.movementbasedanimations.Turning.TurnRight;

using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.movementbasedanimations.Turning
{
	public class JTParent_Turning : MonoBehaviour	
	{
		private JTParent_TurnLeft JTParent_TurnLeft;
		private JTParent_TurnRight JTParent_TurnRight;

		public void JTParent_TurningController()
		{
			if (JTParent_TurnLeft == null)
			{
				Load_JTParent_TurnLeft();
			}
			if (JTParent_TurnRight == null)
			{
				Load_JTParent_TurnRight();
			}
		}

		private void Load_JTParent_TurnRight()
		{
			JTParent_TurnRight.JTParent_TurnRightController();
		}
		
		private void Load_JTParent_TurnLeft()
		{
			JTParent_TurnLeft.JTParent_TurnLeftController();
		}
	}
}