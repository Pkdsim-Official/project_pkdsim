using project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations.Turning
{
	public class TParent_Turning : MonoBehaviour	
	{
		private TParent_TurnLeft TParent_TurnLeft;
		private TParent_TurnRight TParent_TurnRight;

		public void TParent_TurningController()
		{
			if (TParent_TurnLeft != null)
			{
				Load_TParent_TurnLeft();
			}

			if (TParent_TurnRight != null)
			{
				Load_TParent_TurnRight();
			}
		}
		private void Load_TParent_TurnRight()
		{
			TParent_TurnRight.TParent_TurnRightController();
		}
		
		private void Load_TParent_TurnLeft()
		{
			TParent_TurnLeft.TParent_TurnLeftController();
		}
	}
}