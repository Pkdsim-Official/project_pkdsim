using project_pkdsim.ANIMATOR.Parents.Beedrill.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Beedrill.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.movementbasedanimations.Strafing
{
	public class BEParent_Strafing : MonoBehaviour 
	{
		private BE_StrafeLeft BE_strafeleft;
		
		private BE_StrafeRight BE_straferight;

		public void BEParent_StrafingController()
		{
			if (BE_strafeleft == null)
			{
				Load_BEStrafeLeft();
			}
			if (BE_straferight == null)
			{
				Load_BEStrafeRight();
			}
			

		}
		private void Load_BEStrafeRight()
		{
			BE_straferight.BE_StrafeRightController();
		}
		
		private void Load_BEStrafeLeft()
		{
			BE_strafeleft.BE_StrafeLeftController();
		}
	}
}