using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.movementbasedanimations.Turning
{
	public class GARDParent_Turning : MonoBehaviour	
	{
		private GARDParent_TurnLeft GARDParent_TurnLeft;
		private GARDParent_TurnRight GARDParent_TurnRight;

		public void GARDParent_TurningController()
		{
			if (GARDParent_TurnLeft == null)
			{
				Load_GARDParent_TurnLeft();
			}
			if (GARDParent_TurnRight == null)
			{
				Load_GARDParent_TurnRight();
			}
		}

		private void Load_GARDParent_TurnRight()
		{
			GARDParent_TurnRight.GARDParent_TurnRightController();
		}
		
		private void Load_GARDParent_TurnLeft()
		{
			GARDParent_TurnLeft.GARDParent_TurnLeftController();
		}
	}
}