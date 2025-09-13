using project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations.Turning
{
	public class HATParent_Turning : MonoBehaviour	
	{
		private HATParent_TurnLeft HATParent_TurnLeft;
		private HATParent_TurnRight HATParent_TurnRight;

		public void HATParent_TurningController()
		{
			if (HATParent_TurnLeft == null)
			{
				Load_HATParent_TurnLeft();
			}
			if (HATParent_TurnRight == null)
			{
				Load_HATParent_TurnRight();
			}
		}

		private void Load_HATParent_TurnRight()
		{
			HATParent_TurnRight.HATParent_TurnRightController();
		}
		
		private void Load_HATParent_TurnLeft()
		{
			HATParent_TurnLeft.HATParent_TurnLeftController();
		}
	}
}