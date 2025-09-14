using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Turning
{
	public class JTParentMom_Turning : MonoBehaviour	
	{
		private JTParentMom_TurnLeft JTParentMom_TurnLeft;
		private JTParentMom_TurnRight JTParentMom_TurnRight;

		public void JTParentMom_TurningController()
		{
			if (JTParentMom_TurnLeft != null)
			{
				
				Load_JTParentMom_TurnLeft();
			}

			if (JTParentMom_TurnRight != null)
			{
				Load_JTParentMom_TurnRight();
			}
			
		}
		private void Load_JTParentMom_TurnRight()
		{
			JTParentMom_TurnRight.JTParentMom_TurnRightController();
		}
		
		private void Load_JTParentMom_TurnLeft()
		{
			JTParentMom_TurnLeft.JTParentMom_TurnLeftController();
		}
	}
}