using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.movementbasedanimations.Turning
{
	public class MEOWParentDad_Parent_Turning : MonoBehaviour	
	{
		private MEOWParentDad_Parent_TurnLeft MEOWParentDad_Parent_TurnLeft;
		private MEOWParentDad_Parent_TurnRight MEOWParentDad_Parent_TurnRight;

		public void MEOWParentDad_Parent_TurningController()
		{
			if (MEOWParentDad_Parent_TurnLeft == null)
			{
				Load_MEOWParentDad_Parent_TurnLeft();
			}
			if (MEOWParentDad_Parent_TurnRight == null)
			{
				Load_MEOWParentDad_Parent_TurnRight();
			}
		}

		private void Load_MEOWParentDad_Parent_TurnRight()
		{
			MEOWParentDad_Parent_TurnRight.MEOWParentDad_Parent_TurnRightController();
		}
		
		private void Load_MEOWParentDad_Parent_TurnLeft()
		{
			MEOWParentDad_Parent_TurnLeft.MEOWParentDad_Parent_TurnLeftController();
		}
	}
}