using project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Turning
{
	public class UMParentDad_Turning : MonoBehaviour	
	{
		private UMParentDad_TurnLeft UMParentDad_TurnLeft;
		private UMParentDad_TurnRight UMParentDad_TurnRight;

		public void UMParentDad_TurningController()
		{
			if (UMParentDad_TurnLeft == null)
			{
				Load_UMParentDad_TurnLeft();
			}
			if (UMParentDad_TurnRight == null)
			{
				Load_UMParentDad_TurnRight();
			}
		}

		private void Load_UMParentDad_TurnRight()
		{
			UMParentDad_TurnRight.UMParentDad_TurnRightController();
		}
		
		private void Load_UMParentDad_TurnLeft()
		{
			UMParentDad_TurnLeft.UMParentDad_TurnLeftController();
		}
	}
}