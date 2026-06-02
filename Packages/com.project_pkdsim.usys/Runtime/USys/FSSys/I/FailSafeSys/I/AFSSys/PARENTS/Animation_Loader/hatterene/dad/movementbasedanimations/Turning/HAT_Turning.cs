using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Turning
{
	public class HATParentDad_Turning : MonoBehaviour	
	{
		private HATParentDad_TurnLeft HATParentDad_TurnLeft;
		private HATParentDad_TurnRight HATParentDad_TurnRight;

		public void HATParentDad_TurningController()
		{
			if (HATParentDad_TurnLeft == null)
			{
				Load_HATParentDad_TurnLeft();
			}
			if (HATParentDad_TurnRight == null)
			{
				Load_HATParentDad_TurnRight();
			}
		}

		private void Load_HATParentDad_TurnRight()
		{
			HATParentDad_TurnRight.HATParentDad_TurnRightController();
		}
		
		private void Load_HATParentDad_TurnLeft()
		{
			HATParentDad_TurnLeft.HATParentDad_TurnLeftController();
		}
	}
}