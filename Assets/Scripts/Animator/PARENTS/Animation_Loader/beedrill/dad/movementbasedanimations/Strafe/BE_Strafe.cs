using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Strafing
{
	public class BEParentDad_Strafing : MonoBehaviour 
	{
		private BEParentDad_StrafeLeft BEParentDad_strafeleft;
		
		private BEParentDad_StrafeRight BEParentDad_straferight;

		public void BEParentDad_StrafingController()
		{
			if (BEParentDad_strafeleft == null)
			{
				Load_BEStrafeLeft();
			}
			if (BEParentDad_straferight == null)
			{
				Load_BEStrafeRight();
			}
			

		}
		private void Load_BEStrafeRight()
		{
			BEParentDad_straferight.BEParentDad_StrafeRightController();
		}
		
		private void Load_BEStrafeLeft()
		{
			BEParentDad_strafeleft.BEParentDad_StrafeLeftController();
		}
	}
}