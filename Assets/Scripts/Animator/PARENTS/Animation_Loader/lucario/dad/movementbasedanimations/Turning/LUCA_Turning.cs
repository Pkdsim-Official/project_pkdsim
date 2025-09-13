using project_pkdsim.ANIMATOR.Parents.Lucario.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Lucario.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.movementbasedanimations.Turning
{
	public class LUCAParent_Turning : MonoBehaviour	
	{
		private LUCAParent_TurnLeft LUCAParent_TurnLeft;
		private LUCAParent_TurnRight LUCAParent_TurnRight;

		public void LUCAParent_TurningController()
		{
			if (LUCAParent_TurnLeft != null)
			{
				Load_LUCAParent_TurnLeft();
			}

			if (LUCAParent_TurnRight != null)
			{
				Load_LUCAParent_TurnRight();
			}
			
		}
		private void Load_LUCAParent_TurnRight()
		{
			LUCAParent_TurnRight.LUCAParent_TurnRightController();
		}
		
		private void Load_LUCAParent_TurnLeft()
		{
			LUCAParent_TurnLeft.LUCAParent_TurnLeftController();
		}
	}
}