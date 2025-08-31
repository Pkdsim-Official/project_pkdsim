using project_pkdsim.Models.ANIMATOR.NPC.Noivern.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Noivern.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Noivern.movementbasedanimations.Strafing
{
	public class NOI_Strafing : MonoBehaviour 
	{
		private NOI_StrafeLeft NOI_strafeleft;
		
		private NOI_StrafeRight NOI_straferight;

		public void NOI_StrafingController()
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