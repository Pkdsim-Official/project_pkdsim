using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Turning
{
	public class LUCAParentMom_Turning : MonoBehaviour	
	{
		private LUCAParentMom_TurnLeft LUCAParentMom_TurnLeft;
		private LUCAParentMom_TurnRight LUCAParentMom_TurnRight;

		public void LUCAParentMom_TurningController()
		{
			if (LUCAParentMom_TurnLeft != null)
			{
				
				Load_LUCAParentMom_TurnLeft();
			}

			if (LUCAParentMom_TurnRight != null)
			{
				Load_LUCAParentMom_TurnRight();
			}
			
		}
		private void Load_LUCAParentMom_TurnRight()
		{
			LUCAParentMom_TurnRight.LUCAParentMom_TurnRightController();
		}
		
		private void Load_LUCAParentMom_TurnLeft()
		{
			LUCAParentMom_TurnLeft.LUCAParentMom_TurnLeftController();
		}
	}
}