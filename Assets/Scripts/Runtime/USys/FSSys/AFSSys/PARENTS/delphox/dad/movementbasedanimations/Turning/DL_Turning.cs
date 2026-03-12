using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.movementbasedanimations.Turning
{
	public class DLParent_Turning : MonoBehaviour	
	{
		private DLParent_TurnLeft DLParent_TurnLeft;
		private DLParent_TurnRight DLParent_TurnRight;

		public void DLParent_TurningController()
		{
			if (DLParent_TurnLeft == null)
			{
				Load_DLParent_TurnLeft();
			}
			if (DLParent_TurnRight == null)
			{
				Load_DLParent_TurnRight();
			}
			

		}
		private void Load_DLParent_TurnRight()
		{
			DLParent_TurnRight.DLParent_TurnRightController();
		}
		
		private void Load_DLParent_TurnLeft()
		{
			DLParent_TurnLeft.DLParent_TurnLeftController();
		}
	}
}