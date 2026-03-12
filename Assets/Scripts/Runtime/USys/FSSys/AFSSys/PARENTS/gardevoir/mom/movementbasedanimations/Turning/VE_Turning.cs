using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Turning
{
	public class GARDParentMom_Turning : MonoBehaviour	
	{
		private GARDParentMom_TurnLeft GARDParentMom_TurnLeft;
		private GARDParentMom_TurnRight GARDParentMom_TurnRight;

		public void GARDParentMom_TurningController()
		{
			if (GARDParentMom_TurnLeft != null)
			{
				
				Load_GARDParentMom_TurnLeft();
			}

			if (GARDParentMom_TurnRight != null)
			{
				Load_GARDParentMom_TurnRight();
			}
			
		}
		private void Load_GARDParentMom_TurnRight()
		{
			GARDParentMom_TurnRight.GARDParentMom_TurnRightController();
		}
		
		private void Load_GARDParentMom_TurnLeft()
		{
			GARDParentMom_TurnLeft.GARDParentMom_TurnLeftController();
		}
	}
}