using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Turning
{
	public class LOParentMom_Turning : MonoBehaviour	
	{
		private LOParentMom_TurnLeft LOParent_TurnLeft;
		private LOParentMom_TurnRight LOParent_TurnRight;

		public void LOParentMom_TurningController()
		{
			if (LOParent_TurnLeft == null)
			{
				Load_LOParent_TurnLeft();
			}

			if (LOParent_TurnRight == null)
			{
				Load_LOParent_TurnRight();
			}
			
		}
		private void Load_LOParent_TurnRight()
		{
			LOParent_TurnRight.LOParentMom_TurnRightController();
		}
		
		private void Load_LOParent_TurnLeft()
		{
			LOParent_TurnLeft.LOParentMom_TurnLeftController();
		}
	}
}