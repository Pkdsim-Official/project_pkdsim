using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Strafing
{
	public class VEParentMom_Strafing : MonoBehaviour 
	{
		private VEParentMom_StrafeLeft VEParentMom_strafeleft;
		
		private VEParentMom_StrafeRight VEParentMom_straferight;

		public void VEParentMom_StrafingController()
		{
			if (VEParentMom_strafeleft == null)
			{
				Load_VEParentMom_StrafeLeft();
			}
			if (VEParentMom_straferight == null)
			{
				Load_VEParentMom_StrafeRight();
			}
		}
		private void Load_VEParentMom_StrafeRight()
		{
			VEParentMom_straferight.VEParentMom_StrafeRightController();
		}
		
		private void Load_VEParentMom_StrafeLeft()
		{
			VEParentMom_strafeleft.VEParentMom_StrafeLeftController();
		}
	}
}