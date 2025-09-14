using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Strafing
{
	public class VPParentMom_Strafing : MonoBehaviour 
	{
		private VPParentMom_StrafeLeft VPParentMom_strafeleft;
		
		private VPParentMom_StrafeRight VPParentMom_straferight;

		public void VPParentMom_StrafingController()
		{
			if (VPParentMom_strafeleft == null)
			{
				Load_VPParentMom_StrafeLeft();
			}
			if (VPParentMom_straferight == null)
			{
				Load_VPParentMom_StrafeRight();
			}
		}
		private void Load_VPParentMom_StrafeRight()
		{
			VPParentMom_straferight.VPParentMom_StrafeRightController();
		}
		
		private void Load_VPParentMom_StrafeLeft()
		{
			VPParentMom_strafeleft.VPParentMom_StrafeLeftController();
		}
	}
}