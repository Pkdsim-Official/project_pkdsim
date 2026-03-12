using Project_Pkdsim.ANIMATOR.Parents.Dragapult.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Parents.Dragapult.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Dragapult.movementbasedanimations.Turning
{
	public class DRParent_Turning : MonoBehaviour	
	{
		private DRParent_TurnLeft DRParent_TurnLeft;
		private DRParent_TurnRight DRParent_TurnRight;

		public void DRParent_TurningController()
		{
			if (DRParent_TurnLeft == null)
			{
				Load_DRParent_TurnLeft();
			}
			if (DRParent_TurnRight == null)
			{
				Load_DRParent_TurnRight();
			}
		}

		private void Load_DRParent_TurnRight()
		{
			DRParent_TurnRight.DRParent_TurnRightController();
		}
		
		private void Load_DRParent_TurnLeft()
		{
			DRParent_TurnLeft.DRParent_TurnLeftController();
		}
	}
}