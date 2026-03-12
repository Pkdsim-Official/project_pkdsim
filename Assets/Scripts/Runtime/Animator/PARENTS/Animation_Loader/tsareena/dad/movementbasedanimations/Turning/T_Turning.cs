using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Turning
{
	public class TParentDad_Turning : MonoBehaviour	
	{
		private TParentDad_TurnLeft TParentDad_TurnLeft;
		private TParentDad_TurnRight TParentDad_TurnRight;

		public void TParentDad_TurningController()
		{
			if (TParentDad_TurnLeft != null)
			{
				Load_TParentDad_TurnLeft();
			}

			if (TParentDad_TurnRight != null)
			{
				Load_TParentDad_TurnRight();
			}
		}
		private void Load_TParentDad_TurnRight()
		{
			TParentDad_TurnRight.TParentDad_TurnRightController();
		}
		
		private void Load_TParentDad_TurnLeft()
		{
			TParentDad_TurnLeft.TParentDad_TurnLeftController();
		}
	}
}