using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.movementbasedanimations.Turning
{
	public class HATParentMom_Turning : MonoBehaviour	
	{
		private HATParentMom_TurnLeft HATParentMom_TurnLeft;
		private HATParentMom_TurnRight HATParentMom_TurnRight;

		public void HATParentMom_TurningController()
		{
			if (HATParentMom_TurnLeft == null)
			{
				Load_HATParentMom_TurnLeft();
			}
			if (HATParentMom_TurnRight == null)
			{
				Load_HATParentMom_TurnRight();
			}
		}

		private void Load_HATParentMom_TurnRight()
		{
			HATParentMom_TurnRight.HATParentMom_TurnRightController();
		}
		
		private void Load_HATParentMom_TurnLeft()
		{
			HATParentMom_TurnLeft.HATParentMom_TurnLeftController();
		}
	}
}