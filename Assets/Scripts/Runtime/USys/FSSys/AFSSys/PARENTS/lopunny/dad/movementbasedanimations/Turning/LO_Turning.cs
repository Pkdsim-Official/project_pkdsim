using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Turning
{
	public class LOParentDad_Turning : MonoBehaviour	
	{
		private LOParentDad_TurnLeft LOParentDad_TurnLeft;
		private LOParentDad_TurnRight LOParentDad_TurnRight;

		public void LOParentDad_TurningController()
		{
			if (LOParentDad_TurnLeft == null)
			{
				Load_LOParentDad_TurnLeft();
			}

			if (LOParentDad_TurnRight == null)
			{
				Load_LOParentDad_TurnRight();
			}
			
		}
		private void Load_LOParentDad_TurnRight()
		{
			LOParentDad_TurnRight.LOParentDad_TurnRightController();
		}
		
		private void Load_LOParentDad_TurnLeft()
		{
			LOParentDad_TurnLeft.LOParentDad_TurnLeftController();
		}
	}
}