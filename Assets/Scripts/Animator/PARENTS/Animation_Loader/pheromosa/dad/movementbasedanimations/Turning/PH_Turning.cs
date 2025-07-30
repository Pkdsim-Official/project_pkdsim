using project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations.Turning
{
	public class PHParent_Turning : MonoBehaviour	
	{
		private PHParent_TurnLeft PHParent_TurnLeft;
		private PHParent_TurnRight PHParent_TurnRight;

		public void PHParent_TurningController()
		{
			if (PHParent_TurnLeft != null)
			{
				Load_PHParent_TurnLeft();
			}
			
			if (PHParent_TurnRight != null)
			{
				Load_PHParent_TurnRight();
			}
			

		}
		private void Load_PHParent_TurnRight()
		{
			PHParent_TurnRight.PHParent_TurnRightController();
		}
		
		private void Load_PHParent_TurnLeft()
		{
			PHParent_TurnLeft.PHParent_TurnLeftController();
		}
	}
}