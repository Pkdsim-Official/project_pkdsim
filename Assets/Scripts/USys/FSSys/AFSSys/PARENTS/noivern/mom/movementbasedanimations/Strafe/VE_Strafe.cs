using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Strafing
{
	public class NOIParentMom_Strafing : MonoBehaviour 
	{
		private NOIParentMom_StrafeLeft NOIParentMom_strafeleft;
		
		private NOIParentMom_StrafeRight NOIParentMom_straferight;

		public void NOIParentMom_StrafingController()
		{
			if (NOIParentMom_strafeleft == null)
			{
				Load_NOIParentMom_StrafeLeft();
			}
			if (NOIParentMom_straferight == null)
			{
				Load_NOIParentMom_StrafeRight();
			}
		}
		private void Load_NOIParentMom_StrafeRight()
		{
			NOIParentMom_straferight.NOIParentMom_StrafeRightController();
		}
		
		private void Load_NOIParentMom_StrafeLeft()
		{
			NOIParentMom_strafeleft.NOIParentMom_StrafeLeftController();
		}
	}
}