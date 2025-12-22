using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Turning
{
	public class CParentMom_Turning : MonoBehaviour	
	{
		private CParentMom_TurnLeft CParentMom_TurnLeft;
		private CParentMom_TurnRight CParentMom_TurnRight;

		public void CParentMom_TurningController()
		{
			if (CParentMom_TurnLeft != null)
			{
				
				Load_CParentMom_TurnLeft();
			}

			if (CParentMom_TurnRight != null)
			{
				Load_CParentMom_TurnRight();
			}
			
		}
		private void Load_CParentMom_TurnRight()
		{
			CParentMom_TurnRight.CParentMom_TurnRightController();
		}
		
		private void Load_CParentMom_TurnLeft()
		{
			CParentMom_TurnLeft.CParentMom_TurnLeftController();
		}
	}
}