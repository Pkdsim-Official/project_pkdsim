using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Turning
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