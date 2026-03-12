using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Strafing
{
	public class CParentMom_Strafing : MonoBehaviour 
	{
		private CParentMom_StrafeLeft CParentMom_strafeleft;
		
		private CParentMom_StrafeRight CParentMom_straferight;

		public void CParentMom_StrafingController()
		{
			if (CParentMom_strafeleft == null)
			{
				Load_CParentMom_StrafeLeft();
			}
			if (CParentMom_straferight == null)
			{
				Load_CParentMom_StrafeRight();
			}
		}
		private void Load_CParentMom_StrafeRight()
		{
			CParentMom_straferight.CParentMom_StrafeRightController();
		}
		
		private void Load_CParentMom_StrafeLeft()
		{
			CParentMom_strafeleft.CParentMom_StrafeLeftController();
		}
	}
}