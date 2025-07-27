using project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.movementbasedanimations.Strafe
{
	public class SA_Strafing : MonoBehaviour 
	{
		private SA_StrafeLeft SA_strafeleft;
		
		private SA_StrafeRight SA_straferight;

		public void SA_StrafingController()
		{
			if (SA_strafeleft == null)
			{
				SA_strafeleft = GetComponent<SA_StrafeLeft>();
				Load_SA_StrafeLeft();
			}
			if (SA_straferight == null)
			{
				SA_straferight = GetComponent<SA_StrafeRight>();
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