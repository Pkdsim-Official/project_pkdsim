using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Strafing
{
	public class VPParentDad_Strafing : MonoBehaviour 
	{
		private VPParentDad_StrafeLeft VP_strafeleft;
		private VPParentDad_StrafeRight VP_straferight;

		public void VPParentDad_StrafingController()
		{
			VPParentDad_StrafeLeftController();
			VPParentDad_StrafeRightController();
		}
		private void VPParentDad_StrafeLeftController()
		{
			VP_strafeleft.VPParentDad_StrafeLeftController();
		}
		private void VPParentDad_StrafeRightController()
		{
			VP_straferight.VPParentDad_StrafeRightController();
		}
	}
}