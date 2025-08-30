using project_pkdsim.Models.ANIMATOR.NPC.Espeon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Espeon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Espeon.movementbasedanimations.Turning
{
	public class ES_Turning : MonoBehaviour	
	{
		private ES_TurnLeft ES_turnleft;
		private ES_TurnRight ES_turnright;

		public void ES_TurningController()
		{
			if (ES_turnleft == null)
			{
				Load_ES_TurningLeft();
			}
			if (ES_turnright == null)
			{
				Load_ES_TurningRight();
			}
		}

		private void Load_ES_TurningRight()
		{
			ES_turnright.ES_TurningRightController();
		}
		
		private void Load_ES_TurningLeft()
		{
			ES_turnleft.ES_TurningLeftController();
		}
	}
}