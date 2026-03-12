using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations.Strafing
{
	public class BRParentMom_Strafing : MonoBehaviour 
	{
		private BRParentMom_StrafeLeft BRParentMom_strafeleft;
		
		private BRParentMom_StrafeRight BRParentMom_straferight;

		public void BRParentMom_StrafingController()
		{
			if (BRParentMom_strafeleft == null)
			{
				Load_BRParentMom_StrafeLeft();
			}
			if (BRParentMom_straferight == null)
			{
				Load_BRParentMom_StrafeRight();
			}
		}
		private void Load_BRParentMom_StrafeRight()
		{
			BRParentMom_straferight.BRParentMom_StrafeRightController();
		}
		
		private void Load_BRParentMom_StrafeLeft()
		{
			BRParentMom_strafeleft.BRParentMom_StrafeLeftController();
		}
	}
}