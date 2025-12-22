using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.movementbasedanimations.Turning
{
	public class SAParent_Turning : MonoBehaviour	
	{
		private SAParent_TurnLeft SAParent_TurnLeft;
		private SAParent_TurnRight SAParent_TurnRight;

		public void SAParent_TurningController()
		{
			if (SAParent_TurnLeft != null)
			{
				Load_SAParentDad_TurnLeft();
			}

			if (SAParent_TurnRight != null)
			{
				Load_SAParentDad_TurnRight();
			}
		}
		private void Load_SAParentDad_TurnRight()
		{
			SAParent_TurnRight.SAParent_TurnRightController();
		}
		
		private void Load_SAParentDad_TurnLeft()
		{
			SAParent_TurnLeft.SAParent_TurnLeftController();
		}
	}
}