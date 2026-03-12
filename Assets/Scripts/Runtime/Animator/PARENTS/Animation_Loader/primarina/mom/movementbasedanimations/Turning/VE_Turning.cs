using Project_Pkdsim.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Turning
{
	public class PRParentMom_Turning : MonoBehaviour	
	{
		private PRParentMom_TurnLeft PRParentMom_TurnLeft;
		private PRParentMom_TurnRight PRParentMom_TurnRight;

		public void PRParentMom_TurningController()
		{
			if (PRParentMom_TurnLeft != null)
			{
				
				Load_PRParentMom_TurnLeft();
			}

			if (PRParentMom_TurnRight != null)
			{
				Load_PRParentMom_TurnRight();
			}
			
		}
		private void Load_PRParentMom_TurnRight()
		{
			PRParentMom_TurnRight.PRParentMom_TurnRightController();
		}
		
		private void Load_PRParentMom_TurnLeft()
		{
			PRParentMom_TurnLeft.PRParentMom_TurnLeftController();
		}
	}
}