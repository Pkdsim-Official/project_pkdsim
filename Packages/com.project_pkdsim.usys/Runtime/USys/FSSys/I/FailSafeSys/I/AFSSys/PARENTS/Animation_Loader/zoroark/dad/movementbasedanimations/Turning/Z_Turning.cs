using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations.Turning
{
	public class ZParentDad_Turning : MonoBehaviour	
	{
		private ZParentDad_TurnLeft ZParentDad_TurnLeft;
		private ZParentDad_TurnRight ZParentDad_TurnRight;

		public void ZParentDad_TurningController()
		{
			if (ZParentDad_TurnLeft != null)
			{
				Load_ZParentDad_TurnLeft();
			}
			
			if (ZParentDad_TurnRight != null)
			{
				Load_ZParentDad_TurnRight();
			}
		}
		private void Load_ZParentDad_TurnRight()
		{
			ZParentDad_TurnRight.ZParentDad_TurnRightController();
		}
		
		private void Load_ZParentDad_TurnLeft()
		{
			ZParentDad_TurnLeft.ZParentDad_TurnLeftController();
		}
	}
}