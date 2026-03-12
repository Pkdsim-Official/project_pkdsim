using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Turning
{
	public class UMParentMom_Turning : MonoBehaviour	
	{
		private UMParentMom_TurnLeft UMParentMom_TurnLeft;
		private UMParentMom_TurnRight UMParentMom_TurnRight;

		public void UMParentMom_TurningController()
		{
			if (UMParentMom_TurnLeft != null)
			{
				
				Load_UMParentMom_TurnLeft();
			}

			if (UMParentMom_TurnRight != null)
			{
				Load_UMParentMom_TurnRight();
			}
			
		}
		private void Load_UMParentMom_TurnRight()
		{
			UMParentMom_TurnRight.UMParentMom_TurnRightController();
		}
		
		private void Load_UMParentMom_TurnLeft()
		{
			UMParentMom_TurnLeft.UMParentMom_TurnLeftController();
		}
	}
}