using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.movementbasedanimations.Turning
{
	public class SYLParentDad_Turning : MonoBehaviour 
	{
		private SYLParentDad_TurnLeft SYLParentDad_TurnLeft;
		private SYLParentDad_TurnRight SYLParentDad_TurnRight;

		public void SYLParentDad_TurningController()
		{
			if (SYLParentDad_TurnLeft == null)
			{
				Load_SYLParentDad_TurnLeft();
			}
			if (SYLParentDad_TurnRight == null)
			{
				Load_SYLParentDad_TurnRight();
			}
		}

		private void Load_SYLParentDad_TurnRight()
		{
			SYLParentDad_TurnRight.SYLParentDad_TurnRightController();
		}
		
		private void Load_SYLParentDad_TurnLeft()
		{
			SYLParentDad_TurnLeft.SYLParentDad_TurnLeftController();
		}

	}
}