using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Turning
{
	public class LEParentDad_Turning : MonoBehaviour	
	{
		private LEParentDad_TurnLeft LEParentDad_TurnLeft;
		private LEParentDad_TurnRight LEParentDad_TurnRight;

		public void LEParentDad_TurningController()
		{
			if (LEParentDad_TurnLeft == null)
			{
				Load_LEParentDad_TurnLeft();
			}
			if (LEParentDad_TurnRight == null)
			{
				Load_LEParentDad_TurnRight();
			}
		}

		private void Load_LEParentDad_TurnRight()
		{
			LEParentDad_TurnRight.LEParentDad_TurnRightController();
		}
		
		private void Load_LEParentDad_TurnLeft()
		{
			LEParentDad_TurnLeft.LEParentDad_TurnLeftController();
		}
	}
}