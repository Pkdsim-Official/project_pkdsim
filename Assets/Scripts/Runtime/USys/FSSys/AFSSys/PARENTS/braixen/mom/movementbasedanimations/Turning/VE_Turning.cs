using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations.Turning
{
	public class BRParentMom_Turning : MonoBehaviour	
	{
		private BRParentMom_TurnLeft BRParentMom_TurnLeft;
		private BRParentMom_TurnRight BRParentMom_TurnRight;

		public void BRParentMom_TurningController()
		{
			if (BRParentMom_TurnLeft != null)
			{
				
				Load_BRParentMom_TurnLeft();
			}

			if (BRParentMom_TurnRight != null)
			{
				Load_BRParentMom_TurnRight();
			}
			
		}
		private void Load_BRParentMom_TurnRight()
		{
			BRParentMom_TurnRight.BRParentMom_TurnRightController();
		}
		
		private void Load_BRParentMom_TurnLeft()
		{
			BRParentMom_TurnLeft.BRParentMom_TurnLeftController();
		}
	}
}