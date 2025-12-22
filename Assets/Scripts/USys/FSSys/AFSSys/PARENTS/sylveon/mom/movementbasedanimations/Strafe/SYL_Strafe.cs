using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Strafing
{
	public class SYLParentMom_Strafing : MonoBehaviour 
	{
		private SYLParentMom_StrafeLeft SYLParentMom_strafeleft;
		
		private SYLParentMom_StrafeRight SYLParentMom_straferight;

		public void SYLParentMom_StrafingController()
		{
			if (SYLParentMom_strafeleft == null)
			{
				Load_SYLParentMom_StrafeLeft();
			}
			if (SYLParentMom_straferight == null)
			{
				Load_SYLParentMom_StrafeRight();
			}
		}
		private void Load_SYLParentMom_StrafeRight()
		{
			SYLParentMom_straferight.SYLParentMom_StrafeRightController();
		}
		
		private void Load_SYLParentMom_StrafeLeft()
		{
			SYLParentMom_strafeleft.SYLParentMom_StrafeLeftController();
		}
	}
}