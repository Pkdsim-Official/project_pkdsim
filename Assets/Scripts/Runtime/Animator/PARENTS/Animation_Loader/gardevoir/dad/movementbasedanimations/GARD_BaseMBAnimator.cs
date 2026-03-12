using Project_Pkdsim.ANIMATOR.Parents.Gardevoir.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Gardevoir.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Gardevoir.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Gardevoir.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Gardevoir.movementbasedanimations
{
	public class GardevoirParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private GARDParent_Jumping Gardevoir_MBA_Jumping;
		
		private GARDParent_Running Gardevoir_MBA_Running;


		private GARDParent_Turning Gardevoir_MBA_Turning;

		private GARDParent_Strafing Gardevoir_MBA_Strafe;

		public void GARDMovementAnimatorController()
		{
			Gardevoir_MBA_Running.GARDParent_RunningController();

			Gardevoir_MBA_Jumping.GARDParent_JumpingController();

			Gardevoir_MBA_Turning.GARDParent_TurningController();	

			Gardevoir_MBA_Strafe.GARDParent_StrafingController();
		}
	}
}