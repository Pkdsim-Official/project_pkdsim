using project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations.Strafing
{
	public class TParent_Strafing : MonoBehaviour 
	{
		private T_StrafeLeft T_strafeleft;
		
		private T_StrafeRight T_straferight;

		public void TParent_StrafingController()
		{
			if (T_strafeleft == null)
			{
				Load_T_StrafeLeft();
			}
			if (T_straferight == null)
			{
				Load_T_StrafeRight();
			}
			

		}
		private void Load_T_StrafeRight()
		{
			T_straferight.T_StrafeRightController();
		}
		
		private void Load_T_StrafeLeft()
		{
			T_strafeleft.T_StrafeLeftController();
		}
	}
}