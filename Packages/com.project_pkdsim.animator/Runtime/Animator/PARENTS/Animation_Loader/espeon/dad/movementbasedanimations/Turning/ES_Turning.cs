using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Turning
{
	public class ESParentDad_Turning : MonoBehaviour	
	{
		private ESParentDad_TurnLeft ESParentDad_TurnLeft;
		private ESParentDad_TurnRight ESParentDad_TurnRight;

		public void ESParentDad_TurningController()
		{
			if (ESParentDad_TurnLeft == null)
			{
				Load_ESParentDad_TurningLeft();
			}
			if (ESParentDad_TurnRight == null)
			{
				Load_ESParentDad_TurningRight();
			}
		}

		private void Load_ESParentDad_TurningRight()
		{
			ESParentDad_TurnRight.ESParentDad_TurningRightController();
		}
		
		private void Load_ESParentDad_TurningLeft()
		{
			ESParentDad_TurnLeft.ESParentDad_TurningLeftController();
		}
	}
}