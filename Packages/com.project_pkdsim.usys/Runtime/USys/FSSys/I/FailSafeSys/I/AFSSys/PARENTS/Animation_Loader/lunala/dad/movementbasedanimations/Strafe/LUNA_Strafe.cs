using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.movementbasedanimations.Strafing
{
	public class LUNAParentDad_Strafing : MonoBehaviour 
	{
		private LUNAParentDadDad_StrafeLeft LUNAParentDadDad_strafeleft;
		
		private LUNAParentDadDad_StrafeRight LUNAParentDadDad_straferight;

		public void LUNAParentDad_StrafingController()
		{
			if (LUNAParentDadDad_strafeleft == null)
			{
				LUNAParentDadDad_strafeleft = GetComponent<LUNAParentDadDad_StrafeLeft>();
				Load_LUNAParentDadDad_StrafeLeft();
			}
			if (LUNAParentDadDad_straferight == null)
			{
				LUNAParentDadDad_straferight = GetComponent<LUNAParentDadDad_StrafeRight>();
				Load_LUNAParentDadDad_StrafeRight();
			}
			

		}
		private void Load_LUNAParentDadDad_StrafeRight()
		{
			LUNAParentDadDad_straferight.LUNAParentDadDad_StrafeRightController();
		}
		
		private void Load_LUNAParentDadDad_StrafeLeft()
		{
			LUNAParentDadDad_strafeleft.LUNAParentDadDad_StrafeLeftController();
		}
	}
}