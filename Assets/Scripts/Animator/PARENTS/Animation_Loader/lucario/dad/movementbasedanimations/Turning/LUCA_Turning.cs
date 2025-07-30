using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations.Turning
{
	public class LUCAParentDad_Turning : MonoBehaviour
	{
		private LUCAParentDad_TurnLeft LUCAParentDad_TurnLeft;
		private LUCAParentDad_TurnRight LUCAParentDad_TurnRight;

		public void LUCAParentDad_TurningController()
		{
			if (LUCAParentDad_TurnLeft != null)
			{
				Load_LUCAParentDad_TurnLeft();
			}

			if (LUCAParentDad_TurnRight != null)
			{
				Load_LUCAParentDad_TurnRight();
			}

		}
		private void Load_LUCAParentDad_TurnRight()
		{
			LUCAParentDad_TurnRight.LUCAParentDad_TurnRightController();
		}

		private void Load_LUCAParentDad_TurnLeft()
		{
			LUCAParentDad_TurnLeft.LUCAParentDad_TurnLeftController();
		}
	}
}