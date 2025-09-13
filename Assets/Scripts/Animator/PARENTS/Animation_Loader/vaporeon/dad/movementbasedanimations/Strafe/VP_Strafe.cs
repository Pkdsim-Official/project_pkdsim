using project_pkdsim.ANIMATOR.Parents.Vaporeon.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.movementbasedanimations.Strafing
{
	public class VPParent_Strafing : MonoBehaviour 
	{
		VP_StrafeLeft VP_strafeleft;
		VP_StrafeRight VP_straferight;
		public void VPParent_StrafingController()
		{
			VP_StrafeLeftController();
			VP_StrafeRightController();
		}
		private void VP_StrafeLeftController()
		{
			VP_strafeleft.VP_StrafeLeftController();
		}
		private void VP_StrafeRightController()
		{
			VP_straferight.VP_StrafeRightController();
		}
	}
}