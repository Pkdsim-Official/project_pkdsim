using Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Turning
{
	public class VEParentDad_Turning : MonoBehaviour	
	{
		private VEParentDad_TurnLeft VEParentDad_TurnLeft;
		private VEParentDad_TurnRight VEParentDad_TurnRight;

		public void VEParentDad_TurningController()
		{
			if (VEParentDad_TurnLeft != null)
			{
				
				Load_VEParentDad_TurnLeft();
			}

			if (VEParentDad_TurnRight != null)
			{
				Load_VEParentDad_TurnRight();
			}
			
		}
		private void Load_VEParentDad_TurnRight()
		{
			VEParentDad_TurnRight.VEParentDad_TurnRightController();
		}
		
		private void Load_VEParentDad_TurnLeft()
		{
			VEParentDad_TurnLeft.VEParentDad_TurnLeftController();
		}
	}
}