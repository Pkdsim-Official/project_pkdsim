using project_pkdsim.Models.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Strafe
{
	public class PH_Strafing : MonoBehaviour 
	{
		private PH_StrafeLeft PH_strafeleft;
		
		private PH_StrafeRight PH_straferight;

		public void PH_StrafingController()
		{
			if (PH_strafeleft == null)
			{
				Load_PH_StrafeLeft();
			}
			if (PH_straferight == null)
			{
				Load_PH_StrafeRight();
			}
			

		}
		private void Load_PH_StrafeRight()
		{
			PH_straferight.PH_StrafeRightController();
		}
		
		private void Load_PH_StrafeLeft()
		{
			PH_strafeleft.PH_StrafeLeftController();
		}
	}
}