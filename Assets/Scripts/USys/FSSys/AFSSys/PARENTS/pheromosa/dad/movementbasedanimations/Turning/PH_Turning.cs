using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Turning
{
	public class PHParentDad_Turning : MonoBehaviour	
	{
		private PHParentDad_TurnLeft PHParentDad_TurnLeft;
		private PHParentDad_TurnRight PHParentDad_TurnRight;

		public void PHParentDad_TurningController()
		{
			if (PHParentDad_TurnLeft != null)
			{
				Load_PHParentDad_TurnLeft();
			}
			
			if (PHParentDad_TurnRight != null)
			{
				Load_PHParentDad_TurnRight();
			}
			

		}
		private void Load_PHParentDad_TurnRight()
		{
			PHParentDad_TurnRight.PHParentDad_TurnRightController();
		}
		
		private void Load_PHParentDad_TurnLeft()
		{
			PHParentDad_TurnLeft.PHParentDad_TurnLeftController();
		}
	}
}