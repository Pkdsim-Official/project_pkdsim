using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Turning
{
	public class BEParentMom_Turning : MonoBehaviour	
	{
		private BEParentMom_TurnLeft BEParentMom_TurnLeft;
		private BEParentMom_TurnRight BEParentMom_TurnRight;

		public void BEParentMom_TurningController()
		{
			if (BEParentMom_TurnLeft != null)
			{
				
				Load_BEParentMom_TurnLeft();
			}

			if (BEParentMom_TurnRight != null)
			{
				Load_BEParentMom_TurnRight();
			}
			
		}
		private void Load_BEParentMom_TurnRight()
		{
			BEParentMom_TurnRight.BEParentMom_TurnRightController();
		}
		
		private void Load_BEParentMom_TurnLeft()
		{
			BEParentMom_TurnLeft.BEParentMom_TurnLeftController();
		}
	}
}