using Project_Pkdsim.ANIMATOR.Parents.Delphox.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Delphox.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Delphox.movementbasedanimations.Strafing
{
	public class DLParent_Strafing : MonoBehaviour 
	{
		private DL_StrafeLeft DL_strafeleft;
		
		private DL_StrafeRight DL_straferight;

		public void DLParent_StrafingController()
		{
			if (DL_strafeleft == null)
			{
				Load_DL_StrafeLeft();
			}
			if (DL_straferight == null)
			{
				Load_DL_StrafeRight();
			}
		}

		private void Load_DL_StrafeRight()
		{
			DL_straferight.DL_StrafeRightController();
		}
		
		private void Load_DL_StrafeLeft()
		{
			DL_strafeleft.DL_StrafeLeftController();
		}
	}
}