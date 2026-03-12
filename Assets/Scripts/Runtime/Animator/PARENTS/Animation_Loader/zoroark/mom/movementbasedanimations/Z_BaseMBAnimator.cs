using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations
{
	public class ZoroarkParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private ZParentMom_Jumping Zoroark_MBA_Jumping;
		
		private ZParentMom_Running Zoroark_MBA_Running;


		private ZParentMom_Turning Zoroark_MBA_Turning;

		private ZParentMom_Strafing Zoroark_MBA_Strafe;

		public void ZParentMom_MovementAnimatorController()
		{
			Zoroark_MBA_Running.ZParentMom_RunningController();

			Zoroark_MBA_Jumping.ZParentMom_JumpingController();

			Zoroark_MBA_Turning.ZParentMom_TurningController();	

			Zoroark_MBA_Strafe.ZParentMom_StrafingController();
		}
	}
}