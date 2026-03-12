using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Turning
{
	public class DLParentMom_Turning : MonoBehaviour	
	{
		private DLParentMom_TurnLeft DLParentMom_TurnLeft;
		private DLParentMom_TurnRight DLParentMom_TurnRight;

		public void DLParentMom_TurningController()
		{
			if (DLParentMom_TurnLeft != null)
			{
				
				Load_DLParentMom_TurnLeft();
			}

			if (DLParentMom_TurnRight != null)
			{
				Load_DLParentMom_TurnRight();
			}
			
		}
		private void Load_DLParentMom_TurnRight()
		{
			DLParentMom_TurnRight.DLParentMom_TurnRightController();
		}
		
		private void Load_DLParentMom_TurnLeft()
		{
			DLParentMom_TurnLeft.DLParentMom_TurnLeftController();
		}
	}
}