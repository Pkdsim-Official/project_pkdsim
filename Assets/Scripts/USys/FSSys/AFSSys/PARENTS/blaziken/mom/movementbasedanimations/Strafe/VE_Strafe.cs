using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Strafing
{
	public class BLParentMom_Strafing : MonoBehaviour 
	{
		private BLParentMom_StrafeLeft BLParentMom_strafeleft;
		
		private BLParentMom_StrafeRight BLParentMom_straferight;

		public void BLParentMom_StrafingController()
		{
			if (BLParentMom_strafeleft == null)
			{
				Load_BLParentMom_StrafeLeft();
			}
			if (BLParentMom_straferight == null)
			{
				Load_BLParentMom_StrafeRight();
			}
		}
		private void Load_BLParentMom_StrafeRight()
		{
			BLParentMom_straferight.BLParentMom_StrafeRightController();
		}
		
		private void Load_BLParentMom_StrafeLeft()
		{
			BLParentMom_strafeleft.BLParentMom_StrafeLeftController();
		}
	}
}