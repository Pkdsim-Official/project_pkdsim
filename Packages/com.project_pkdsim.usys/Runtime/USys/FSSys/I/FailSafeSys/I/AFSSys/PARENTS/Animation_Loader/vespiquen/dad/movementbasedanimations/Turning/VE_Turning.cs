using project_pkdsim.ANIMATOR.Parents.Vespiquen.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.movementbasedanimations.Turning
{
	public class VEParent_Turning : MonoBehaviour	
	{
		private VEParent_TurnLeft VEParent_TurnLeft;
		private VEParent_TurnRight VEParent_TurnRight;

		public void VEParent_TurningController()
		{
			if (VEParent_TurnLeft != null)
			{
				
				Load_VeParent_TurnLeft();
			}

			if (VEParent_TurnRight != null)
			{
				Load_VeParent_TurnRight();
			}
			
		}
		private void Load_VeParent_TurnRight()
		{
			VEParent_TurnRight.VEParent_TurnRightController();
		}
		
		private void Load_VeParent_TurnLeft()
		{
			VEParent_TurnLeft.VEParent_TurnLeftController();
		}
	}
}