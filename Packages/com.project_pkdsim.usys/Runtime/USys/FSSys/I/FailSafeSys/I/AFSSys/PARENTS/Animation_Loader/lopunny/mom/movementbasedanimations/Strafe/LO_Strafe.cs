using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Strafing
{
	public class LOParentMom_Strafing : MonoBehaviour 
	{
		private LOParentMom_StrafeLeft LOParentMom_strafeleft;
		
		private LOParentMom_StrafeRight LOParentMom_straferight;

		public void LOParentMom_StrafingController()
		{
			if (LOParentMom_strafeleft == null)
			{
				Load_LOParentMom_StrafeLeft();
			}
			if (LOParentMom_straferight == null)
			{
				Load_LOParentMom_StrafeRight();
			}
			

		}
		private void Load_LOParentMom_StrafeRight()
		{
			LOParentMom_straferight.LOParentMom_StrafeRightController();
		}
		
		private void Load_LOParentMom_StrafeLeft()
		{
			LOParentMom_strafeleft.LOParentMom_StrafeLeftController();
		}
	}
}