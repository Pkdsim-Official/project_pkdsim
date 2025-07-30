using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Turning
{
	public class ESParentMom_Turning : MonoBehaviour	
	{
		private ESParentMom_TurnLeft ESParentMom_TurnLeft;
		private ESParentMom_TurnRight ESParentMom_TurnRight;

		public void ESParentMom_TurningController()
		{
			if (ESParentMom_TurnLeft != null)
			{
				
				Load_ESParentMom_TurnLeft();
			}

			if (ESParentMom_TurnRight != null)
			{
				Load_ESParentMom_TurnRight();
			}
			
		}
		private void Load_ESParentMom_TurnRight()
		{
			ESParentMom_TurnRight.ESParentMom_TurnRightController();
		}
		
		private void Load_ESParentMom_TurnLeft()
		{
			ESParentMom_TurnLeft.ESParentMom_TurnLeftController();
		}
	}
}