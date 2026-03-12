using Project_Pkdsim.ANIMATOR.Parents.Cinderace.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Cinderace.movementbasedanimations.Turning
{
	public class ParentDad_Turning : MonoBehaviour	
	{
		private ParentDad_TurnLeft ParentDad_TurnLeft;
		private ParentDad_TurnRight ParentDad_TurnRight;

		public void ParentDad_TurningController()
		{
			if (ParentDad_TurnLeft == null)
			{
				Load_ParentDad_TurnLeft();
			}
			if (ParentDad_TurnRight == null)
			{
				Load_ParentDad_TurnRight();
			}
		}

		private void Load_ParentDad_TurnRight()
		{
			ParentDad_TurnRight.ParentDad_TurnRightController();
		}
		
		private void Load_ParentDad_TurnLeft()
		{
			ParentDad_TurnLeft.ParentDad_TurnLeftController();
		}
	}
}