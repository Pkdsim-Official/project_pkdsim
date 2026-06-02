using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing
{
	public class LUNAParentDad_Strafing : MonoBehaviour 
	{
		private LUNAParentDadMom_StrafeLeft LUNAParentDadMom_strafeleft;
		
		private LUNAParentDadMom_StrafeRight LUNAParentDadMom_straferight;

		public void LUNAParentDad_StrafingController()
		{
			if (LUNAParentDadMom_strafeleft == null)
			{
				LUNAParentDadMom_strafeleft = GetComponent<LUNAParentDadMom_StrafeLeft>();
				Load_LUNAParentDadMom_StrafeLeft();
			}
			if (LUNAParentDadMom_straferight == null)
			{
				LUNAParentDadMom_straferight = GetComponent<LUNAParentDadMom_StrafeRight>();
				Load_LUNAParentDadMom_StrafeRight();
			}
			

		}
		private void Load_LUNAParentDadMom_StrafeRight()
		{
			LUNAParentDadMom_straferight.LUNAParentDadMom_StrafeRightController();
		}
		
		private void Load_LUNAParentDadMom_StrafeLeft()
		{
			LUNAParentDadMom_strafeleft.LUNAParentDadMom_StrafeLeftController();
		}
	}
}