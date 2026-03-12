using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Turning
{
	public class LUNAParentMom_Turning : MonoBehaviour	
	{
		private LUNAParentMom_TurnLeft LUNAParentMom_TurnLeft;
		private LUNAParentMom_TurnRight LUNAParentMom_TurnRight;

		public void LUNAParentMom_TurningController()
		{
			if (LUNAParentMom_TurnLeft != null)
			{
				
				Load_LUNAParentMom_TurnLeft();
			}

			if (LUNAParentMom_TurnRight != null)
			{
				Load_LUNAParentMom_TurnRight();
			}
			
		}
		private void Load_LUNAParentMom_TurnRight()
		{
			LUNAParentMom_TurnRight.LUNAParentMom_TurnRightController();
		}
		
		private void Load_LUNAParentMom_TurnLeft()
		{
			LUNAParentMom_TurnLeft.LUNAParentMom_TurnLeftController();
		}
	}
}