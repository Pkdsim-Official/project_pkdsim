using project_pkdsim.ANIMATOR.NPC.Salazzle.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.NPC.Salazzle.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Salazzle.movementbasedanimations.Strafing
{
	public class SA_Strafing : MonoBehaviour 
	{
		private SA_StrafeLeft SA_strafeleft;
		
		private SA_StrafeRight SA_straferight;

		public void SA_StrafingController()
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