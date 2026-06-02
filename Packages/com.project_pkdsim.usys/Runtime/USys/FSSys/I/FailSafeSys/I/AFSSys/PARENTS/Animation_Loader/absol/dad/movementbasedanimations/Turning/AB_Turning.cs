using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Turning
{
	public class ABParentDad_Turning : MonoBehaviour	
	{
		private ABParentDad_TurnLeft ABParentDad_TurnLeft;
		private ABParentDad_TurnRight ABParentDad_TurnRight;

		public void ABParentDad_TurningController()
		{
			if (ABParentDad_TurnLeft == null)
			{
				Load_ABParentDad_TurnLeft();
			}
			if (ABParentDad_TurnRight == null)
			{
				Load_ABParentDad_TurnRight();
			}
		}

		private void Load_ABParentDad_TurnRight()
		{
			ABParentDad_TurnRight.ABParentDad_TurnRightController();
		}
		
		private void Load_ABParentDad_TurnLeft()
		{
			ABParentDad_TurnLeft.ABParentDad_TurnLeftController();
		}
	}
}