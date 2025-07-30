using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Turning
{
	public class LOParentMom_Turning : MonoBehaviour	
	{
		private LOParentMom_TurnLeft LOParentMom_TurnLeft;
		private LOParentMom_TurnRight LOParentMom_TurnRight;

		public void LOParentMom_TurningController()
		{
			if (LOParentMom_TurnLeft != null)
			{
				
				Load_LOParentMom_TurnLeft();
			}

			if (LOParentMom_TurnRight != null)
			{
				Load_LOParentMom_TurnRight();
			}
			
		}
		private void Load_LOParentMom_TurnRight()
		{
			LOParentMom_TurnRight.LOParentMom_TurnRightController();
		}
		
		private void Load_LOParentMom_TurnLeft()
		{
			LOParentMom_TurnLeft.LOParentMom_TurnLeftController();
		}
	}
}