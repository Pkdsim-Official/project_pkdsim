using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Strafing
{
	public class VPParentDad_Strafing : MonoBehaviour 
	{
		VPParentDad_StrafeLeft VPParentDad_strafeleft;
		VPParentDad_StrafeRight VPParentDad_straferight;
		public void VPParentDad_StrafingController()
		{
			VPParentDad_StrafeLeftController();
			VPParentDad_StrafeRightController();
		}
		private void VPParentDad_StrafeLeftController()
		{
			VPParentDad_strafeleft.VPParentDad_StrafeLeftController();
		}
		private void VPParentDad_StrafeRightController()
		{
			VPParentDad_straferight.VPParentDad_StrafeRightController();
		}
	}
}