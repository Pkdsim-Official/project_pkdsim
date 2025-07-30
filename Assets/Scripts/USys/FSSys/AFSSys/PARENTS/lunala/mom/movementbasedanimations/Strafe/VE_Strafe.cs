using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing
{
	public class LUNAParentMom_Strafing : MonoBehaviour 
	{
		private LUNAParentMom_StrafeLeft LUNAParentMom_strafeleft;
		
		private LUNAParentMom_StrafeRight LUNAParentMom_straferight;

		public void LUNAParentMom_StrafingController()
		{
			if (LUNAParentMom_strafeleft == null)
			{
				Load_LUNAParentMom_StrafeLeft();
			}
			if (LUNAParentMom_straferight == null)
			{
				Load_LUNAParentMom_StrafeRight();
			}
		}
		private void Load_LUNAParentMom_StrafeRight()
		{
			LUNAParentMom_straferight.LUNAParentMom_StrafeRightController();
		}
		
		private void Load_LUNAParentMom_StrafeLeft()
		{
			LUNAParentMom_strafeleft.LUNAParentMom_StrafeLeftController();
		}
	}
}