using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Strafing
{
	public class HATParentDad_Strafing : MonoBehaviour 
	{
		private HATParentDad_StrafeLeft HATParentDad_strafeleft;
		
		private HATParentDad_StrafeRight HATParentDad_straferight;

		public void HATParentDad_StrafingController()
		{
			if (HATParentDad_strafeleft == null)
			{
				Load_HATParentDad_StrafeLeft();
			}
			if (HATParentDad_straferight == null)
			{
				Load_HATParentDad_StrafeRight();
			}
			

		}
		private void Load_HATParentDad_StrafeRight()
		{
			HATParentDad_straferight.HATParentDad_StrafeRightController();
		}
		
		private void Load_HATParentDad_StrafeLeft()
		{
			HATParentDad_strafeleft.HATParentDad_StrafeLeftController();
		}
	}
}