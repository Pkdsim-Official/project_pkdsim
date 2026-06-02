using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Strafing
{
	public class VPParentMom_Strafing : MonoBehaviour 
	{
		VPParentMom_StrafeLeft VPParentMom_strafeleft;
		VPParentMom_StrafeRight VPParentMom_straferight;
		public void VPParentMom_StrafingController()
		{
			VPParentMom_StrafeLeftController();
			VPParentMom_StrafeRightController();
		}
		private void VPParentMom_StrafeLeftController()
		{
			VPParentMom_strafeleft.VPParentMom_StrafeLeftController();
		}
		private void VPParentMom_StrafeRightController()
		{
			VPParentMom_straferight.VPParentMom_StrafeRightController();
		}
	}
}