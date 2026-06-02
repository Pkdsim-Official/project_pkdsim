using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Turning.TurnRight;

using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Turning
{
	public class JTParentDad_Turning : MonoBehaviour	
	{
		private JTParentDad_TurnLeft JTParentDad_TurnLeft;
		private JTParentDad_TurnRight JTParentDad_TurnRight;

		public void JTParentDad_TurningController()
		{
			if (JTParentDad_TurnLeft == null)
			{
				Load_JTParentDad_TurnLeft();
			}
			if (JTParentDad_TurnRight == null)
			{
				Load_JTParentDad_TurnRight();
			}
		}

		private void Load_JTParentDad_TurnRight()
		{
			JTParentDad_TurnRight.JTParentDad_TurnRightController();
		}
		
		private void Load_JTParentDad_TurnLeft()
		{
			JTParentDad_TurnLeft.JTParentDad_TurnLeftController();
		}
	}
}