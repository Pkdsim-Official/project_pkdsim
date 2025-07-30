using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Strafing
{
	public class GLParentMom_Strafing : MonoBehaviour 
	{
		private GLParentMom_StrafeLeft GLParentMom_strafeleft;
		
		private GLParentMom_StrafeRight GLParentMom_straferight;

		public void GLParentMom_StrafingController()
		{
			if (GLParentMom_strafeleft == null)
			{
				Load_GLParentMom_StrafeLeft();
			}
			if (GLParentMom_straferight == null)
			{
				Load_GLParentMom_StrafeRight();
			}
		}
		private void Load_GLParentMom_StrafeRight()
		{
			GLParentMom_straferight.GLParentMom_StrafeRightController();
		}
		
		private void Load_GLParentMom_StrafeLeft()
		{
			GLParentMom_strafeleft.GLParentMom_StrafeLeftController();
		}
	}
}