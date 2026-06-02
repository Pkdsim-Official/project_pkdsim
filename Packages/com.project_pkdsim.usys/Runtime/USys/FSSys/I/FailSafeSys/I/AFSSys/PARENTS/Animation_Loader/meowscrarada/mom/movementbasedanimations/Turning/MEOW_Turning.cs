using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Turning
{
	public class MEOWParentMom_Parent_Turning : MonoBehaviour	
	{
		private MEOWParentMom_Parent_TurnLeft MEOWParentMom_Parent_TurnLeft;
		private MEOWParentMom_Parent_TurnRight MEOWParentMom_Parent_TurnRight;

		public void MEOWParentMom_Parent_TurningController()
		{
			if (MEOWParentMom_Parent_TurnLeft == null)
			{
				Load_MEOWParentMom_Parent_TurnLeft();
			}
			if (MEOWParentMom_Parent_TurnRight == null)
			{
				Load_MEOWParentMom_Parent_TurnRight();
			}
		}

		private void Load_MEOWParentMom_Parent_TurnRight()
		{
			MEOWParentMom_Parent_TurnRight.MEOWParentMom_Parent_TurnRightController();
		}
		
		private void Load_MEOWParentMom_Parent_TurnLeft()
		{
			MEOWParentMom_Parent_TurnLeft.MEOWParentMom_Parent_TurnLeftController();
		}
	}
}