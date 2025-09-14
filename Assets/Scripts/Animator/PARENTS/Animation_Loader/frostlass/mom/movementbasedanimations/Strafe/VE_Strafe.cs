using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Strafing
{
	public class FRParentMom_Strafing : MonoBehaviour 
	{
		private FRParentMom_StrafeLeft FRParentMom_strafeleft;
		
		private FRParentMom_StrafeRight FRParentMom_straferight;

		public void FRParentMom_StrafingController()
		{
			if (FRParentMom_strafeleft == null)
			{
				Load_FRParentMom_StrafeLeft();
			}
			if (FRParentMom_straferight == null)
			{
				Load_FRParentMom_StrafeRight();
			}
		}
		private void Load_FRParentMom_StrafeRight()
		{
			FRParentMom_straferight.FRParentMom_StrafeRightController();
		}
		
		private void Load_FRParentMom_StrafeLeft()
		{
			FRParentMom_strafeleft.FRParentMom_StrafeLeftController();
		}
	}
}