using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Turning
{
	public class ESParentMom_Turning : MonoBehaviour	
	{
		private ESParentMom_TurnLeft ESParentMom_TurnLeft;
		private ESParentMom_TurnRight ESParentMom_TurnRight;

		public void ESParentMom_TurningController()
		{
			if (ESParentMom_TurnLeft == null)
			{
				Load_ESParentMom_TurningLeft();
			}
			if (ESParentMom_TurnRight == null)
			{
				Load_ESParentMom_TurningRight();
			}
		}

		private void Load_ESParentMom_TurningRight()
		{
			ESParentMom_TurnRight.ESParentMom_TurningRightController();
		}
		
		private void Load_ESParentMom_TurningLeft()
		{
			ESParentMom_TurnLeft.ESParentMom_TurningLeftController();
		}
	}
}