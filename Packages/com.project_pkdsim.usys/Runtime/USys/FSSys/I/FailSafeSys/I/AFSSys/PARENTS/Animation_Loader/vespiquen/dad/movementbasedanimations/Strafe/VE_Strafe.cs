using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Strafing
{
	public class VEParentDad_Strafing : MonoBehaviour 
	{
		private VEParentMom_StrafeLeft VEParentMom_strafeleft;
		
		private VEParentMom_StrafeRight VEParentMom_straferight;

		public void VEParentDad_StrafingController()
		{
			if (VEParentMom_strafeleft == null)
			{
				VEParentMom_strafeleft = GetComponent<VEParentMom_StrafeLeft>();
				Load_VEParentMom_StrafeLeft();
			}
			if (VEParentMom_straferight == null)
			{
				VEParentMom_straferight = GetComponent<VEParentMom_StrafeRight>();
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