using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Turning
{
	public class GARCParentMom_Turning : MonoBehaviour	
	{
		private GARCParentMom_TurnLeft GARCParentMom_TurnLeft;
		private GARCParentMom_TurnRight GARCParentMom_TurnRight;

		public void GARCParentMom_TurningController()
		{
			if (GARCParentMom_TurnLeft != null)
			{
				
				Load_GARCParentMom_TurnLeft();
			}

			if (GARCParentMom_TurnRight != null)
			{
				Load_GARCParentMom_TurnRight();
			}
			
		}
		private void Load_GARCParentMom_TurnRight()
		{
			GARCParentMom_TurnRight.GARCParentMom_TurnRightController();
		}
		
		private void Load_GARCParentMom_TurnLeft()
		{
			GARCParentMom_TurnLeft.GARCParentMom_TurnLeftController();
		}
	}
}