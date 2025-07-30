using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Turning
{
	public class NOIParentMom_Turning : MonoBehaviour	
	{
		private NOIParentMom_TurnLeft NOIParentMom_TurnLeft;
		private NOIParentMom_TurnRight NOIParentMom_TurnRight;

		public void NOIParentMom_TurningController()
		{
			if (NOIParentMom_TurnLeft != null)
			{
				
				Load_NOIParentMom_TurnLeft();
			}

			if (NOIParentMom_TurnRight != null)
			{
				Load_NOIParentMom_TurnRight();
			}
			
		}
		private void Load_NOIParentMom_TurnRight()
		{
			NOIParentMom_TurnRight.NOIParentMom_TurnRightController();
		}
		
		private void Load_NOIParentMom_TurnLeft()
		{
			NOIParentMom_TurnLeft.NOIParentMom_TurnLeftController();
		}
	}
}