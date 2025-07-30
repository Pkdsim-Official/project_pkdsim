using project_pkdsim.ANIMATOR.Npcs.Espeon.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Npcs.Espeon.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Espeon.movementbasedanimations.Strafing
{
	public class ES_Strafing : MonoBehaviour 
	{
		private ES_StrafeLeft ES_strafeleft;
		
		private ES_StrafeRight ES_straferight;

		public void ES_StrafingController()
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