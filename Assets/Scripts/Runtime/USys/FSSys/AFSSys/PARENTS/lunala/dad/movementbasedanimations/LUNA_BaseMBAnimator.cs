using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.movementbasedanimations
{
	public class LunalaParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private LUNAParent_Jumping Lunala_MBA_Jumping;
		
		private LUNAParent_Running Lunala_MBA_Running;


		private LUNAParent_Turning Lunala_MBA_Turning;

		private LUNAParent_Strafing Lunala_MBA_Strafe;

		public void LUNAMovementAnimatorController()
		{
			Lunala_MBA_Running.LUNAParent_RunningController();

			Lunala_MBA_Jumping.LUNAParent_JumpingController();

			Lunala_MBA_Turning.LUNAParent_TurningController();	

			Lunala_MBA_Strafe.LUNAParent_StrafingController();
		}
	}
}