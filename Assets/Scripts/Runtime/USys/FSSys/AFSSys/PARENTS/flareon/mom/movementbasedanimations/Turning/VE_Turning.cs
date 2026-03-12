using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Turning
{
	public class FLParentMom_Turning : MonoBehaviour	
	{
		private FLParentMom_TurnLeft FLParentMom_TurnLeft;
		private FLParentMom_TurnRight FLParentMom_TurnRight;

		public void FLParentMom_TurningController()
		{
			if (FLParentMom_TurnLeft != null)
			{
				
				Load_FLParentMom_TurnLeft();
			}

			if (FLParentMom_TurnRight != null)
			{
				Load_FLParentMom_TurnRight();
			}
			
		}
		private void Load_FLParentMom_TurnRight()
		{
			FLParentMom_TurnRight.FLParentMom_TurnRightController();
		}
		
		private void Load_FLParentMom_TurnLeft()
		{
			FLParentMom_TurnLeft.FLParentMom_TurnLeftController();
		}
	}
}