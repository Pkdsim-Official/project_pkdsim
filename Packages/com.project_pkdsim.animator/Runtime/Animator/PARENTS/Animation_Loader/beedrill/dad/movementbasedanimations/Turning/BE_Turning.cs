using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Turning
{
	public class BEParent_Turning : MonoBehaviour	
	{
		private BEParent_TurnLeft BEParent_TurnLeft;
		private BEParent_TurnRight BEParent_TurnRight;

		public void BEParent_TurningController()
		{
			if (BEParent_TurnLeft == null)
			{
				Load_BEParent_TurnLeft();
			}
			if (BEParent_TurnRight == null)
			{
				Load_BEParent_TurnRight();
			}
		}

		private void Load_BEParent_TurnRight()
		{
			BEParent_TurnRight.BEParent_TurnRightController();
		}
		
		private void Load_BEParent_TurnLeft()
		{
			BEParent_TurnLeft.BEParent_TurnLeftController();
		}
	}
}