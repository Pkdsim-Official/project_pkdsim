using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Turning
{
	public class ABParent_Turning : MonoBehaviour	
	{
		private ABParent_TurnLeft ABParent_TurnLeft;
		private ABParent_TurnRight ABParent_TurnRight;

		public void ABParent_TurningController()
		{
			if (ABParent_TurnLeft == null)
			{
				Load_ABParent_TurnLeft();
			}
			if (ABParent_TurnRight == null)
			{
				Load_ABParent_TurnRight();
			}
		}

		private void Load_ABParent_TurnRight()
		{
			ABParent_TurnRight.ABParent_TurnRightController();
		}
		
		private void Load_ABParent_TurnLeft()
		{
			ABParent_TurnLeft.ABParent_TurnLeftController();
		}
	}
}