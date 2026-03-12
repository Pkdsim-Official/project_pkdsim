using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Turning
{
	public class TParentMom_Turning : MonoBehaviour	
	{
		private TParentMom_TurnLeft TParentMom_TurnLeft;
		private TParentMom_TurnRight TParentMom_TurnRight;

		public void TParentMom_TurningController()
		{
			if (TParentMom_TurnLeft != null)
			{
				
				Load_TParentMom_TurnLeft();
			}

			if (TParentMom_TurnRight != null)
			{
				Load_TParentMom_TurnRight();
			}
			
		}
		private void Load_TParentMom_TurnRight()
		{
			TParentMom_TurnRight.TParentMom_TurnRightController();
		}
		
		private void Load_TParentMom_TurnLeft()
		{
			TParentMom_TurnLeft.TParentMom_TurnLeftController();
		}
	}
}