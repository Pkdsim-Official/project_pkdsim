using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Turning
{
	public class NOIParentDad_Turning : MonoBehaviour
	{
		private NOIParentDad_TurnLeft NOIParentDad_TurnLeft;
		private NOIParentDad_TurnRight NOIParentDad_TurnRight;

		public void NOIParentDad_TurningController()
		{
			if (NOIParentDad_TurnLeft == null)
			{
				Load_NOIParentDad_TurnLeft();
			}

			if (NOIParentDad_TurnRight == null)
			{
				Load_NOIParentDad_TurnRight();
			}
		}

		private void Load_NOIParentDad_TurnRight()
		{
			NOIParentDad_TurnRight.NOIParentDad_TurnRightController();
		}

		private void Load_NOIParentDad_TurnLeft()
		{
			NOIParentDad_TurnLeft.NOIParentDad_TurnLeftController();
		}
	}
}