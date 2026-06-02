using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.movementbasedanimations.Turning
{
	public class GARCParentDad_Turning : MonoBehaviour	
	{
		private GARCParentDad_TurnLeft GARCParentDad_TurnLeft;
		private GARCParentDad_TurnRight GARCParentDad_TurnRight;

		public void GARCParentDad_TurningController()
		{
			if (GARCParentDad_TurnLeft == null)
			{
				Load_GARCParentDad_TurnLeft();
			}
			if (GARCParentDad_TurnRight == null)
			{
				Load_GARCParentDad_TurnRight();
			}
		}

		private void Load_GARCParentDad_TurnRight()
		{
			GARCParentDad_TurnRight.GARCParentDad_TurnRightController();
		}
		
		private void Load_GARCParentDad_TurnLeft()
		{
			GARCParentDad_TurnLeft.GARCParentDad_TurnLeftController();
		}
	}
}