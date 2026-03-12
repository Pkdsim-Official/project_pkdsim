using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Strafing
{
	public class FLParentMom_Strafing : MonoBehaviour 
	{
		private FLParentMom_StrafeLeft FLParentMom_strafeleft;
		
		private FLParentMom_StrafeRight FLParentMom_straferight;

		public void FLParentMom_StrafingController()
		{
			if (FLParentMom_strafeleft == null)
			{
				Load_FLParentMom_StrafeLeft();
			}
			if (FLParentMom_straferight == null)
			{
				Load_FLParentMom_StrafeRight();
			}
		}
		private void Load_FLParentMom_StrafeRight()
		{
			FLParentMom_straferight.FLParentMom_StrafeRightController();
		}
		
		private void Load_FLParentMom_StrafeLeft()
		{
			FLParentMom_strafeleft.FLParentMom_StrafeLeftController();
		}
	}
}