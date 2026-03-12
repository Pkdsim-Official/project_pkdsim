using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Turning
{
	public class DRParentMom_Turning : MonoBehaviour	
	{
		private DRParentMom_TurnLeft DRParentMom_TurnLeft;
		private DRParentMom_TurnRight DRParentMom_TurnRight;

		public void DRParentMom_TurningController()
		{
			if (DRParentMom_TurnLeft != null)
			{
				
				Load_DRParentMom_TurnLeft();
			}

			if (DRParentMom_TurnRight != null)
			{
				Load_DRParentMom_TurnRight();
			}
			
		}
		private void Load_DRParentMom_TurnRight()
		{
			DRParentMom_TurnRight.DRParentMom_TurnRightController();
		}
		
		private void Load_DRParentMom_TurnLeft()
		{
			DRParentMom_TurnLeft.DRParentMom_TurnLeftController();
		}
	}
}