using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Turning
{
	public class MEOWParentMom_Turning : MonoBehaviour	
	{
		private MEOWParentMom_TurnLeft MEOWParentMom_TurnLeft;
		private MEOWParentMom_TurnRight MEOWParentMom_TurnRight;

		public void MEOWParentMom_TurningController()
		{
			if (MEOWParentMom_TurnLeft != null)
			{
				
				Load_MEOWParentMom_TurnLeft();
			}

			if (MEOWParentMom_TurnRight != null)
			{
				Load_MEOWParentMom_TurnRight();
			}
			
		}
		private void Load_MEOWParentMom_TurnRight()
		{
			MEOWParentMom_TurnRight.MEOWParentMom_TurnRightController();
		}
		
		private void Load_MEOWParentMom_TurnLeft()
		{
			MEOWParentMom_TurnLeft.MEOWParentMom_TurnLeftController();
		}
	}
}