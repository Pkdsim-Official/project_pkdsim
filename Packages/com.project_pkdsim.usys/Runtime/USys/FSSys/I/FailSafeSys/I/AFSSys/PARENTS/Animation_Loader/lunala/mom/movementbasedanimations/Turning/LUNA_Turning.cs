using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Turning
{
	public class LUNAParentDad_Turning : MonoBehaviour	
	{
		private LUNAParentDad_TurnLeft LUNAParentDad_TurnLeft;
		private LUNAParentDad_TurnRight LUNAParentDad_TurnRight;

		public void LUNAParentDad_TurningController()
		{
			if (LUNAParentDad_TurnLeft == null)
			{
				Load_LUNAParentDad_TurnLeft();
			}

			if (LUNAParentDad_TurnRight == null)
			{
				Load_LUNAParentDad_TurnRight();
			}
		}

		private void Load_LUNAParentDad_TurnRight()
		{
			LUNAParentDad_TurnRight.LUNAParentDad_TurnRightController();
		}
		
		private void Load_LUNAParentDad_TurnLeft()
		{
			LUNAParentDad_TurnLeft.LUNAParentDad_TurnLeftController();
		}
	}
}