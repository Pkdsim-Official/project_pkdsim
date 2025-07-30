using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Turning
{
	public class BEParentDad_Turning : MonoBehaviour	
	{
		private BEParentDad_TurnLeft BEParentDad_TurnLeft;
		private BEParentDad_TurnRight BEParentDad_TurnRight;

		public void BEParentDad_TurningController()
		{
			if (BEParentDad_TurnLeft == null)
			{
				Load_BEParentDad_TurnLeft();
			}
			if (BEParentDad_TurnRight == null)
			{
				Load_BEParentDad_TurnRight();
			}
		}

		private void Load_BEParentDad_TurnRight()
		{
			BEParentDad_TurnRight.BEParentDad_TurnRightController();
		}
		
		private void Load_BEParentDad_TurnLeft()
		{
			BEParentDad_TurnLeft.BEParentDad_TurnLeftController();
		}
	}
}