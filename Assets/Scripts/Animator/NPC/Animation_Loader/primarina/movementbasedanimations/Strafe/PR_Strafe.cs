using project_pkdsim.ANIMATOR.NPC.Primarina.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.NPC.Primarina.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Primarina.movementbasedanimations.Strafing
{
	public class PR_Strafing : MonoBehaviour 
	{
		private PR_StrafeLeft PR_strafeleft;
		
		private PR_StrafeRight PR_straferight;

		public void PR_StrafingController()
		{
			if (PR_strafeleft == null)
			{
				Load_PR_StrafeLeft();
			}
			if (PR_straferight == null)
			{
				Load_PR_StrafeRight();
			}
		}

		private void Load_PR_StrafeRight()
		{
			PR_straferight.PR_StrafeRightController();
		}
		
		private void Load_PR_StrafeLeft()
		{
			PR_strafeleft.PR_StrafeLeftController();
		}
	}
}