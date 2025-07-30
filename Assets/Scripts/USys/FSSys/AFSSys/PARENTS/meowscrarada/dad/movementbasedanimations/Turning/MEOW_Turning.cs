using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Turning
{
	public class MEOWParent_Turning : MonoBehaviour	
	{
		private MEOWParent_TurnLeft MEOWParent_TurnLeft;
		private MEOWParent_TurnRight MEOWParent_TurnRight;

		public void MEOWParent_TurningController()
		{
			if (MEOWParent_TurnLeft == null)
			{
				Load_MEOWParent_TurnLeft();
			}
			if (MEOWParent_TurnRight == null)
			{
				Load_MEOWParent_TurnRight();
			}
		}

		private void Load_MEOWParent_TurnRight()
		{
			MEOWParent_TurnRight.MEOWParent_TurnRightController();
		}
		
		private void Load_MEOWParent_TurnLeft()
		{
			MEOWParent_TurnLeft.MEOWParent_TurnLeftController();
		}
	}
}