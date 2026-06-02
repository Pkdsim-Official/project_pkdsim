using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Dad.movementbasedanimations.Strafing
{
	public class SAParent_Strafing : MonoBehaviour 
	{
		private SA_StrafeLeft SA_strafeleft;
		
		private SA_StrafeRight SA_straferight;

		public void SAParent_StrafingController()
		{
			if (SA_strafeleft == null)
			{
				Load_SA_StrafeLeft();
			}
			if (SA_straferight == null)
			{
				Load_SA_StrafeRight();
			}
			

		}
		private void Load_SA_StrafeRight()
		{
			SA_straferight.SA_StrafeRightController();
		}
		
		private void Load_SA_StrafeLeft()
		{
			SA_strafeleft.SA_StrafeLeftController();
		}
	}
}