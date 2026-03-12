using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Turning
{
	public class ESParent_Turning : MonoBehaviour	
	{
		private ESParent_TurnLeft ESParent_TurnLeft;
		private ESParent_TurnRight ESParent_TurnRight;

		public void ESParent_TurningController()
		{
			if (ESParent_TurnLeft == null)
			{
				Load_ESParent_TurningLeft();
			}
			if (ESParent_TurnRight == null)
			{
				Load_ESParent_TurningRight();
			}
		}

		private void Load_ESParent_TurningRight()
		{
			ESParent_TurnRight.ESParent_TurningRightController();
		}
		
		private void Load_ESParent_TurningLeft()
		{
			ESParent_TurnLeft.ESParent_TurningLeftController();
		}
	}
}