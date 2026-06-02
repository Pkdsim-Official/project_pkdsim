using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Turning
{
	public class BRParent_Turning : MonoBehaviour	
	{
		BRParent_TurnLeft BRParent_TurnLeft;
		BRParent_TurnRight BRParent_TurnRight;

		public void BRParent_TurningController()
		{
			if (BRParent_TurnLeft == null)
			{
				Load_BRParent_TurnLeft();
			}
			if (BRParent_TurnRight == null)
			{
				Load_BRParent_TurnRight();
			}
		}
		
		private void Load_BRParent_TurnRight()
		{
			BRParent_TurnRight.BRParent_TurnRightController();
		}
		
		private void Load_BRParent_TurnLeft()
		{
			BRParent_TurnLeft.BRParent_TurnLeftController();
		}
	}
}