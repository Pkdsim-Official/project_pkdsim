using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Strafing
{
	public class NOIParent_Strafing : MonoBehaviour 
	{
		private NOI_StrafeLeft NOI_strafeleft;
		
		private NOI_StrafeRight NOI_straferight;

		public void NOIParent_StrafingController()
		{
			if (NOI_strafeleft == null)
			{
				Load_NOI_StrafeLeft();
			}
			if (NOI_straferight == null)
			{
				Load_NOI_StrafeRight();
			}
			

		}
		private void Load_NOI_StrafeRight()
		{
			NOI_straferight.NOI_StrafeRightController();
		}
		
		private void Load_NOI_StrafeLeft()
		{
			NOI_strafeleft.NOI_StrafeLeftController();
		}
	}
}