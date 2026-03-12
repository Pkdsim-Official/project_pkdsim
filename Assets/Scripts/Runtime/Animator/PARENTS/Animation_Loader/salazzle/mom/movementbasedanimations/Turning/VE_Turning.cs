using Project_Pkdsim.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Turning
{
	public class SParentMom_Turning : MonoBehaviour	
	{
		private SParentMom_TurnLeft SParentMom_TurnLeft;
		private SParentMom_TurnRight SParentMom_TurnRight;

		public void SParentMom_TurningController()
		{
			if (SParentMom_TurnLeft != null)
			{
				
				Load_SParentMom_TurnLeft();
			}

			if (SParentMom_TurnRight != null)
			{
				Load_SParentMom_TurnRight();
			}
			
		}
		private void Load_SParentMom_TurnRight()
		{
			SParentMom_TurnRight.SParentMom_TurnRightController();
		}
		
		private void Load_SParentMom_TurnLeft()
		{
			SParentMom_TurnLeft.SParentMom_TurnLeftController();
		}
	}
}