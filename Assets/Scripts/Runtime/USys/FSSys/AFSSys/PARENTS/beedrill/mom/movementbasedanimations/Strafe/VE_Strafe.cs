using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Strafing
{
	public class BEParentMom_Strafing : MonoBehaviour 
	{
		private BEParentMom_StrafeLeft BEParentMom_strafeleft;
		
		private BEParentMom_StrafeRight BEParentMom_straferight;

		public void BEParentMom_StrafingController()
		{
			if (BEParentMom_strafeleft == null)
			{
				Load_BEParentMom_StrafeLeft();
			}
			if (BEParentMom_straferight == null)
			{
				Load_BEParentMom_StrafeRight();
			}
		}
		private void Load_BEParentMom_StrafeRight()
		{
			BEParentMom_straferight.BEParentMom_StrafeRightController();
		}
		
		private void Load_BEParentMom_StrafeLeft()
		{
			BEParentMom_strafeleft.BEParentMom_StrafeLeftController();
		}
	}
}