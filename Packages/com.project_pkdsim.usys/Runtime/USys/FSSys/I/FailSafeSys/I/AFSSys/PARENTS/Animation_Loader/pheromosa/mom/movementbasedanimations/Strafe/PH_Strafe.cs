using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Strafing
{
	public class PHParent_Strafing : MonoBehaviour 
	{
		private PH_StrafeLeft PH_strafeleft;
		
		private PH_StrafeRight PH_straferight;

		public void PHParent_StrafingController()
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