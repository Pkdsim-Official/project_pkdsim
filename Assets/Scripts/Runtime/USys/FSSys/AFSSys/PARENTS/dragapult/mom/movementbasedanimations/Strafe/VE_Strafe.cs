using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Strafing
{
	public class DRParentMom_Strafing : MonoBehaviour 
	{
		private DRParentMom_StrafeLeft DRParentMom_strafeleft;
		
		private DRParentMom_StrafeRight DRParentMom_straferight;

		public void DRParentMom_StrafingController()
		{
			if (DRParentMom_strafeleft == null)
			{
				Load_DRParentMom_StrafeLeft();
			}
			if (DRParentMom_straferight == null)
			{
				Load_DRParentMom_StrafeRight();
			}
		}
		private void Load_DRParentMom_StrafeRight()
		{
			DRParentMom_straferight.DRParentMom_StrafeRightController();
		}
		
		private void Load_DRParentMom_StrafeLeft()
		{
			DRParentMom_strafeleft.DRParentMom_StrafeLeftController();
		}
	}
}