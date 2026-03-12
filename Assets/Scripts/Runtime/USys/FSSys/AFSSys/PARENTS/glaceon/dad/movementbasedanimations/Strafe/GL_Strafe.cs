using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Strafing
{
	public class GLParentDad_Strafe : MonoBehaviour 
	{
		private GLParentDad_StrafeLeft GLParentDad_strafeleft;
		
		private GLParentDad_StrafeRight GLParentDad_straferight;

		public void GLParentDad_StrafingController()
		{
			if (GLParentDad_strafeleft == null)
			{
				Load_GLParentDad_StrafeLeft();
			}
			if (GLParentDad_straferight == null)
			{
				Load_GLParentDad_StrafeRight();
			}
		}
		private void Load_GLParentDad_StrafeRight()
		{
			GLParentDad_straferight.GLParentDad_StrafeRightController();
		}
		
		private void Load_GLParentDad_StrafeLeft()
		{
			GLParentDad_strafeleft.GLParentDad_StrafeLeftController();
		}
	}
}