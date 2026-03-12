using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Turning
{
	public class BRParentDad_Turning : MonoBehaviour	
	{
		BRParentDad_TurnLeft BRParentDad_TurnLeft;
		BRParentDad_TurnRight BRParentDad_TurnRight;

		public void BRParentDad_TurningController()
		{
			if (BRParentDad_TurnLeft == null)
			{
				Load_BRParentDad_TurnLeft();
			}
			if (BRParentDad_TurnRight == null)
			{
				Load_BRParentDad_TurnRight();
			}
		}
		
		private void Load_BRParentDad_TurnRight()
		{
			BRParentDad_TurnRight.BRParentDad_TurnRightController();
		}
		
		private void Load_BRParentDad_TurnLeft()
		{
			BRParentDad_TurnLeft.BRParentDad_TurnLeftController();
		}
	}
}