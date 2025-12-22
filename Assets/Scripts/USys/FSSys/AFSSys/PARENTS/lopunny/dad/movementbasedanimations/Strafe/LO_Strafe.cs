using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Strafing
{
	public class LOParentDad_Strafing : MonoBehaviour 
	{
		private LO_StrafeLeft LO_strafeleft;
		
		private LO_StrafeRight LO_straferight;

		public void LOParentDad_StrafingController()
		{
			if (LO_strafeleft == null)
			{
				Load_LO_StrafeLeft();
			}
			if (LO_straferight == null)
			{
				Load_LO_StrafeRight();
			}
			

		}
		private void Load_LO_StrafeRight()
		{
			LO_straferight.LO_StrafeRightController();
		}
		
		private void Load_LO_StrafeLeft()
		{
			LO_strafeleft.LO_StrafeLeftController();
		}
	}
}