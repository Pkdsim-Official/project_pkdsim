using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Strafing
{
	public class LOParentDad_Strafing : MonoBehaviour 
	{
		private LOParentDad_StrafeLeft LOParentDad_strafeleft;
		
		private LOParentDad_StrafeRight LOParentDad_straferight;

		public void LOParentDad_StrafingController()
		{
			if (LOParentDad_strafeleft == null)
			{
				Load_LOParentDad_StrafeLeft();
			}
			if (LOParentDad_straferight == null)
			{
				Load_LOParentDad_StrafeRight();
			}
			

		}
		private void Load_LOParentDad_StrafeRight()
		{
			LOParentDad_straferight.LOParentDad_StrafeRightController();
		}
		
		private void Load_LOParentDad_StrafeLeft()
		{
			LOParentDad_strafeleft.LOParentDad_StrafeLeftController();
		}
	}
}