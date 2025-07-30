using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Turning
{
	public class VEParentMom_Turning : MonoBehaviour	
	{
		private VEParentMom_TurnLeft VEParentMom_TurnLeft;
		private VEParentMom_TurnRight VEParentMom_TurnRight;

		public void VEParentMom_TurningController()
		{
			if (VEParentMom_TurnLeft != null)
			{
				
				Load_VeParentMom_TurnLeft();
			}

			if (VEParentMom_TurnRight != null)
			{
				Load_VeParentMom_TurnRight();
			}
			
		}
		private void Load_VeParentMom_TurnRight()
		{
			VEParentMom_TurnRight.VEParentMom_TurnRightController();
		}
		
		private void Load_VeParentMom_TurnLeft()
		{
			VEParentMom_TurnLeft.VEParentMom_TurnLeftController();
		}
	}
}