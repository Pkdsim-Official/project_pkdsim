using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Turning
{
	public class PHParentMom_Turning : MonoBehaviour	
	{
		private PHParentMom_TurnLeft PHParentMom_TurnLeft;
		private PHParentMom_TurnRight PHParentMom_TurnRight;

		public void PHParentMom_TurningController()
		{
			if (PHParentMom_TurnLeft != null)
			{
				Load_PHParentMom_TurnLeft();
			}

			if (PHParentMom_TurnRight != null)
			{
				Load_PHParentMom_TurnRight();
			}
			
		}
		private void Load_PHParentMom_TurnRight()
		{
			PHParentMom_TurnRight.PHParentMom_TurnRightController();
		}

		private void Load_PHParentMom_TurnLeft()
		{
			PHParentMom_TurnLeft.PHParentMom_TurnLeftController();
		}
	}
}