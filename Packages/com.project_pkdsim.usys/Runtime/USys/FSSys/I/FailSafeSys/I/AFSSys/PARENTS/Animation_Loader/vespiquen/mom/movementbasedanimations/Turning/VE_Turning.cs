using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Turning
{
	public class VEParentMom_Turning : MonoBehaviour	
	{
		private VEParentMom_TurnLeft VEParentMom_TurnLeft;
		private VEParentMom_TurnRight VEParentMom_TurnRight;

		public void VEParentMom_TurningController()
		{
			if (VEParentMom_TurnLeft != null)
			{
				
				Load_VeParent_TurnLeft();
			}

			if (VEParentMom_TurnRight != null)
			{
				Load_VeParent_TurnRight();
			}
			
		}
		private void Load_VeParent_TurnRight()
		{
			VEParentMom_TurnRight.VEParentMom_TurnRightController();
		}
		
		private void Load_VeParent_TurnLeft()
		{
			VEParentMom_TurnLeft.VEParentMom_TurnLeftController();
		}
	}
}