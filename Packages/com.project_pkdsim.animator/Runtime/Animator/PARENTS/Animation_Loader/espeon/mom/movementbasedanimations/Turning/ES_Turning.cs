using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Turning
{
	public class ESParent_Turning : MonoBehaviour	
	{
		private ESParent_TurnLeft ESParent_TurnLeft;
		private ESParent_TurnRight ESParent_TurnRight;

		public void ESParent_TurningController()
		{
			if (ESParent_TurnLeft == null)
			{
				Load_ESParent_TurningLeft();
			}
			if (ESParent_TurnRight == null)
			{
				Load_ESParent_TurningRight();
			}
		}

		private void Load_ESParent_TurningRight()
		{
			ESParent_TurnRight.ESParent_TurningRightController();
		}
		
		private void Load_ESParent_TurningLeft()
		{
			ESParent_TurnLeft.ESParent_TurningLeftController();
		}
	}
}