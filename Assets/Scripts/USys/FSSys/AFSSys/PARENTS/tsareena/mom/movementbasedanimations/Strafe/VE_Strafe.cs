using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Strafing
{
	public class TParentMom_Strafing : MonoBehaviour 
	{
		private TParentMom_StrafeLeft TParentMom_strafeleft;
		
		private TParentMom_StrafeRight TParentMom_straferight;

		public void TParentMom_StrafingController()
		{
			if (TParentMom_strafeleft == null)
			{
				Load_TParentMom_StrafeLeft();
			}
			if (TParentMom_straferight == null)
			{
				Load_TParentMom_StrafeRight();
			}
		}
		private void Load_TParentMom_StrafeRight()
		{
			TParentMom_straferight.TParentMom_StrafeRightController();
		}
		
		private void Load_TParentMom_StrafeLeft()
		{
			TParentMom_strafeleft.TParentMom_StrafeLeftController();
		}
	}
}