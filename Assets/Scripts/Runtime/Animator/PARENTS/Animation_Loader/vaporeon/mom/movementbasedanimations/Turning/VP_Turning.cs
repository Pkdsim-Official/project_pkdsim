using Project_Pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Turning
{
	public class VPParentMom_Turning : MonoBehaviour	
	{
		private VPParentMom_TurnLeft VPParentMom_TurnLeft;
		private VPParentMom_TurnRight VPParentMom_TurnRight;

		public void VPParentMom_TurningController()
		{
			if (VPParentMom_TurnLeft != null)
			{
				
				Load_VPParentMom_TurnLeft();
			}

			if (VPParentMom_TurnRight != null)
			{
				Load_VPParentMom_TurnRight();
			}
			
		}
		private void Load_VPParentMom_TurnRight()
		{
			VPParentMom_TurnRight.VPParentMom_TurnRightController();
		}
		
		private void Load_VPParentMom_TurnLeft()
		{
			VPParentMom_TurnLeft.VPParentMom_TurnLeftController();
		}
	}
}