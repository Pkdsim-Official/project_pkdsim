using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations.Turning
{
	public class FLParentDad_Turning : MonoBehaviour	
	{
		private FLParentDad_TurnLeft FLParentDad_TurnLeft;
		private FLParentDad_TurnRight FLParentDad_TurnRight;

		public void FLParentDad_TurningController()
		{
			if (FLParentDad_TurnLeft == null)
			{
				Load_FLParentDad_TurnLeft();
			}
			if (FLParentDad_TurnRight == null)
			{
				Load_FLParentDad_TurnRight();
			}
		}

		private void Load_FLParentDad_TurnRight()
		{
			FLParentDad_TurnRight.FLParentDad_TurnRightController();
		}
		
		private void Load_FLParentDad_TurnLeft()
		{
			FLParentDad_TurnLeft.FLParentDad_TurnLeftController();
		}
	}
}