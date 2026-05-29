using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Turning
{
	public class UMParent_Turning : MonoBehaviour	
	{
		private UMParent_TurnLeft UMParent_TurnLeft;
		private UMParent_TurnRight UMParent_TurnRight;

		public void UMParent_TurningController()
		{
			if (UMParent_TurnLeft == null)
			{
				Load_UMParent_TurnLeft();
			}
			if (UMParent_TurnRight == null)
			{
				Load_UMParent_TurnRight();
			}
		}

		private void Load_UMParent_TurnRight()
		{
			UMParent_TurnRight.UMParent_TurnRightController();
		}
		
		private void Load_UMParent_TurnLeft()
		{
			UMParent_TurnLeft.UMParent_TurnLeftController();
		}
	}
}