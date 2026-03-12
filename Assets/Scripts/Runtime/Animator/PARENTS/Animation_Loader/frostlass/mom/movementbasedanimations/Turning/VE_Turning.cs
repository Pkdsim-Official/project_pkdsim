using Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Turning
{
	public class FRParentMom_Turning : MonoBehaviour	
	{
		private FRParentMom_TurnLeft FRParentMom_TurnLeft;
		private FRParentMom_TurnRight FRParentMom_TurnRight;

		public void FRParentMom_TurningController()
		{
			if (FRParentMom_TurnLeft != null)
			{
				
				Load_FRParentMom_TurnLeft();
			}

			if (FRParentMom_TurnRight != null)
			{
				Load_FRParentMom_TurnRight();
			}
			
		}
		private void Load_FRParentMom_TurnRight()
		{
			FRParentMom_TurnRight.FRParentMom_TurnRightController();
		}
		
		private void Load_FRParentMom_TurnLeft()
		{
			FRParentMom_TurnLeft.FRParentMom_TurnLeftController();
		}
	}
}