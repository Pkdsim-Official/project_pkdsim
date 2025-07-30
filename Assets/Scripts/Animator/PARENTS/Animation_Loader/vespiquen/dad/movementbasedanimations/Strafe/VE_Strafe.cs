using project_pkdsim.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Strafing
{
	public class VEParentDad_Strafing : MonoBehaviour 
	{
		private VE_StrafeLeft VE_strafeleft;
		
		private VE_StrafeRight VE_straferight;

		public void VEParentDad_StrafingController()
		{
			if (VE_strafeleft == null)
			{
				VE_strafeleft = GetComponent<VE_StrafeLeft>();
				Load_VE_StrafeLeft();
			}
			if (VE_straferight == null)
			{
				VE_straferight = GetComponent<VE_StrafeRight>();
				Load_VE_StrafeRight();
			}
			

		}
		private void Load_VE_StrafeRight()
		{
			VE_straferight.VE_StrafeRightController();
		}
		
		private void Load_VE_StrafeLeft()
		{
			VE_strafeleft.VE_StrafeLeftController();
		}
	}
}