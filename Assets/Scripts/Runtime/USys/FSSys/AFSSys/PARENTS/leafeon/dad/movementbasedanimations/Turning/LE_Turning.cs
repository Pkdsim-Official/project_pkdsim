using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Turning
{
	public class LEParent_Turning : MonoBehaviour	
	{
		private LEParent_TurnLeft LEParent_TurnLeft;
		private LEParent_TurnRight LEParent_TurnRight;

		public void LEParent_TurningController()
		{
			if (LEParent_TurnLeft == null)
			{
				Load_LEParent_TurnLeft();
			}
			if (LEParent_TurnRight == null)
			{
				Load_LEParent_TurnRight();
			}
		}

		private void Load_LEParent_TurnRight()
		{
			LEParent_TurnRight.LEParent_TurnRightController();
		}
		
		private void Load_LEParent_TurnLeft()
		{
			LEParent_TurnLeft.LEParent_TurnLeftController();
		}
	}
}