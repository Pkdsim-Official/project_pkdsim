using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations
{
	public class HattereneParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private HATParentDad_Jumping HAT_MBA_Jumping;
		
		private HATParentDad_Running HAT_MBA_Running;


		private HATParentDad_Turning HAT_MBA_Turning;

		private HATParentDad_Strafing HAT_MBA_Strafe;

		public void HATParentDad_MovementAnimatorController()
		{
			HAT_MBA_Running.HATParentDad_RunningController();

			HAT_MBA_Jumping.HATParentDad_JumpingController();

			HAT_MBA_Turning.HATParentDad_TurningController();	

			HAT_MBA_Strafe.HATParentDad_StrafingController();
		}
	}
}