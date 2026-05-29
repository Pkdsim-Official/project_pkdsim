using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Turning
{
	public class VPParent_Turning : MonoBehaviour	
	{
		private VPParent_TurnLeft VPParent_TurnLeft;
		private VPParent_TurnRight VPParent_TurnRight;

		public void VPParent_TurningController()
		{
			if (VPParent_TurnLeft == null)
			{
				Load_VPParent_TurnLeft();
			}
			if (VPParent_TurnRight == null)
			{
				Load_VPParent_TurnRight();
			}
		}

		private void Load_VPParent_TurnRight()
		{
			VPParent_TurnRight.VPParent_TurnRightController();
		}
		
		private void Load_VPParent_TurnLeft()
		{
			VPParent_TurnLeft.VPParent_TurnLeftController();
		}
	}
}