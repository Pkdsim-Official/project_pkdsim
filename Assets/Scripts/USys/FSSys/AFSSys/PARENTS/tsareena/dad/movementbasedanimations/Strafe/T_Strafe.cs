using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Strafing
{
	public class TParentDad_Strafing : MonoBehaviour 
	{
		private T_StrafeLeft T_strafeleft;
		
		private T_StrafeRight T_straferight;

		public void TParentDad_StrafingController()
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