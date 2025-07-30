using project_pkdsim.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Turning
{
	public class VPParentDad_Turning : MonoBehaviour
	{
		private VPParentDad_TurnLeft VPParentDad_TurnLeft;
		private VPParentDad_TurnRight VPParentDad_TurnRight;

		public void VPParentDad_TurningController()
		{
			if (VPParentDad_TurnLeft == null)
			{
				Load_VPParentDad_TurnLeft();
			}
			if (VPParentDad_TurnRight == null)
			{
				Load_VPParentDad_TurnRight();
			}
		}

		private void Load_VPParentDad_TurnRight()
		{
			VPParentDad_TurnRight.VPParentDad_TurnRightController();
		}

		private void Load_VPParentDad_TurnLeft()
		{
			VPParentDad_TurnLeft.VPParentDad_TurnLeftController();
		}
	}
}