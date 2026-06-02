using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations.Turning
{
	public class ZParentMom_Turning : MonoBehaviour	
	{
		private ZParentMom_TurnLeft ZParentMom_TurnLeft;
		private ZParentMom_TurnRight ZParentMom_TurnRight;

		public void ZParentMom_TurningController()
		{
			if (ZParentMom_TurnLeft != null)
			{
				Load_ZParentMomMom_TurnLeft();
			}
			
			if (ZParentMom_TurnRight != null)
			{
				Load_ZParentMomMom_TurnRight();
			}
		}
		private void Load_ZParentMomMom_TurnRight()
		{
			ZParentMom_TurnRight.ZParentMom_TurnRightController();
		}
		
		private void Load_ZParentMomMom_TurnLeft()
		{
			ZParentMom_TurnLeft.ZParentMom_TurnLeftController();
		}
	}
}