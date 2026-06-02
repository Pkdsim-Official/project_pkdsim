using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Turning
{
	public class CParent_Turning : MonoBehaviour	
	{
		private CParent_TurnLeft CParent_TurnLeft;
		private CParent_TurnRight CParent_TurnRight;

		public void CParent_TurningController()
		{
			if (CParent_TurnLeft == null)
			{
				Load_CParent_TurnLeft();
			}
			if (CParent_TurnRight == null)
			{
				Load_CParent_TurnRight();
			}
		}

		private void Load_CParent_TurnRight()
		{
			CParent_TurnRight.CParent_TurnRightController();
		}
		
		private void Load_CParent_TurnLeft()
		{
			CParent_TurnLeft.CParent_TurnLeftController();
		}
	}
}