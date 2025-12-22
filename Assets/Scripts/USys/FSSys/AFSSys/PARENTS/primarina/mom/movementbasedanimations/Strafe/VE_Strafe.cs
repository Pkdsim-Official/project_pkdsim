using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Strafing
{
	public class PRParentMom_Strafing : MonoBehaviour 
	{
		private PRParentMom_StrafeLeft PRParentMom_strafeleft;
		
		private PRParentMom_StrafeRight PRParentMom_straferight;

		public void PRParentMom_StrafingController()
		{
			if (PRParentMom_strafeleft == null)
			{
				Load_PRParentMom_StrafeLeft();
			}
			if (PRParentMom_straferight == null)
			{
				Load_PRParentMom_StrafeRight();
			}
		}
		private void Load_PRParentMom_StrafeRight()
		{
			PRParentMom_straferight.PRParentMom_StrafeRightController();
		}
		
		private void Load_PRParentMom_StrafeLeft()
		{
			PRParentMom_strafeleft.PRParentMom_StrafeLeftController();
		}
	}
}