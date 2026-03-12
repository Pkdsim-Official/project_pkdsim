using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations.Strafing
{
	public class ZParentMom_Strafing : MonoBehaviour 
	{
		private ZParentMom_StrafeLeft ZParentMom_strafeleft;
		
		private ZParentMom_StrafeRight ZParentMom_straferight;

		public void ZParentMom_StrafingController()
		{
			if (ZParentMom_strafeleft == null)
			{
				Load_ZParentMom_StrafeLeft();
			}
			if (ZParentMom_straferight == null)
			{
				Load_ZParentMom_StrafeRight();
			}
			

		}
		private void Load_ZParentMom_StrafeRight()
		{
			ZParentMom_straferight.ZParentMom_StrafeRightController();
		}
		
		private void Load_ZParentMom_StrafeLeft()
		{
			ZParentMom_strafeleft.ZParentMom_StrafeLeftController();
		}
	}
}