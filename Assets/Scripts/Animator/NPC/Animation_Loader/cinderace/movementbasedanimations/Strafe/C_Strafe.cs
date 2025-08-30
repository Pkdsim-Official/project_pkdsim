using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Cinderace.movementbasedanimations.Strafe
{
	public class C_Strafing : MonoBehaviour 
	{
		private C_StrafeLeft C_strafeleft;
		
		private C_StrafeRight C_straferight;

		public void C_StrafingController()
		{
			if (C_strafeleft == null)
			{
				Load_C_StrafeLeft();
			}
			if (C_straferight == null)
			{
				Load_C_StrafeRight();
			}
			

		}
		private void Load_C_StrafeRight()
		{
			C_straferight.C_StrafeRightController();
		}
		
		private void Load_C_StrafeLeft()
		{
			C_strafeleft.C_StrafeLeftController();
		}
	}
}