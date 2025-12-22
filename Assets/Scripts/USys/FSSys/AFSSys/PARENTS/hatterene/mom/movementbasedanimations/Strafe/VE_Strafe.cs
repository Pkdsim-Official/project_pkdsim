using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Strafing
{
	public class HATParentMom_Strafing : MonoBehaviour 
	{
		private HATParentMom_StrafeLeft HATParentMom_strafeleft;
		
		private HATParentMom_StrafeRight HATParentMom_straferight;

		public void HATParentMom_StrafingController()
		{
			if (HATParentMom_strafeleft == null)
			{
				Load_HATParentMom_StrafeLeft();
			}
			if (HATParentMom_straferight == null)
			{
				Load_HATParentMom_StrafeRight();
			}
		}
		private void Load_HATParentMom_StrafeRight()
		{
			HATParentMom_straferight.HATParentMom_StrafeRightController();
		}
		
		private void Load_HATParentMom_StrafeLeft()
		{
			HATParentMom_strafeleft.HATParentMom_StrafeLeftController();
		}
	}
}