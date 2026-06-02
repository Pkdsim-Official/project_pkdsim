using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Turning
{
	public class DLParent_Turning : MonoBehaviour	
	{
		private DLParent_TurnLeft DLParent_TurnLeft;
		private DLParent_TurnRight DLParent_TurnRight;

		public void DLParent_TurningController()
		{
			if (DLParent_TurnLeft == null)
			{
				Load_DLParent_TurnLeft();
			}
			if (DLParent_TurnRight == null)
			{
				Load_DLParent_TurnRight();
			}
			

		}
		private void Load_DLParent_TurnRight()
		{
			DLParent_TurnRight.DLParent_TurnRightController();
		}
		
		private void Load_DLParent_TurnLeft()
		{
			DLParent_TurnLeft.DLParent_TurnLeftController();
		}
	}
}