using Project_Pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Strafing
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