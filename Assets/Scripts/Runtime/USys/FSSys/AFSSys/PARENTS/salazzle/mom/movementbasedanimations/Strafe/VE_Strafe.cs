using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Strafing
{
	public class SParentMom_Strafing : MonoBehaviour 
	{
		private SParentMom_StrafeLeft SParentMom_strafeleft;
		
		private SParentMom_StrafeRight SParentMom_straferight;

		public void SParentMom_StrafingController()
		{
			if (SParentMom_strafeleft == null)
			{
				Load_SParentMom_StrafeLeft();
			}
			if (SParentMom_straferight == null)
			{
				Load_SParentMom_StrafeRight();
			}
		}
		private void Load_SParentMom_StrafeRight()
		{
			SParentMom_straferight.SParentMom_StrafeRightController();
		}
		
		private void Load_SParentMom_StrafeLeft()
		{
			SParentMom_strafeleft.SParentMom_StrafeLeftController();
		}
	}
}