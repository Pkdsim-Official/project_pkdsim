using project_pkdsim.ANIMATOR.Npcs.Cinderace.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Npcs.Cinderace.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Cinderace.movementbasedanimations.Strafing
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