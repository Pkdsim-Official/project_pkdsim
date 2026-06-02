using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Turning
{
	public class FRParent_Turning : MonoBehaviour	
	{
		private FRParent_TurnLeft FRParent_TurnLeft;
		private FRParent_TurnRight FRParent_TurnRight;

		public void FRParent_TurningController()
		{
			if (FRParent_TurnLeft == null)
			{
				Load_FRParent_TurnLeft();
			}
			if (FRParent_TurnRight == null)
			{
				Load_FRParent_TurnRight();
			}
		}
		
		private void Load_FRParent_TurnRight()
		{
			FRParent_TurnRight.FRParent_TurnRightController();
		}
		
		private void Load_FRParent_TurnLeft()
		{
			FRParent_TurnLeft.FRParent_TurnLeftController();
		}
	}
}