using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Strafing
{
	public class ESParent_Strafing : MonoBehaviour 
	{
		private ES_StrafeLeft ES_strafeleft;
		
		private ES_StrafeRight ES_straferight;

		public void ESParent_StrafingController()
		{
			if (ES_strafeleft == null)
			{
				Load_ES_StrafeLeft();
			}
			if (ES_straferight == null)
			{
				Load_ES_StrafeRight();
			}
			

		}
		private void Load_ES_StrafeRight()
		{
			ES_straferight.ES_StrafeRightController();
		}
		
		private void Load_ES_StrafeLeft()
		{
			ES_strafeleft.ES_StrafeLeftController();
		}
	}
}