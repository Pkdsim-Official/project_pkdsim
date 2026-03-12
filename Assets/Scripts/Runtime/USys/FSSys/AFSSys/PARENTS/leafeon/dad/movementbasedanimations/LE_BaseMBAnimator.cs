using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations
{
	public class LeafeonParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private LEParent_Jumping LE_MBA_Jumping;
		
		private LEParent_Running LE_MBA_Running;

		private LEParent_Turning LE_MBA_Turning;

		private LEParent_Strafing LE_MBA_Strafe;

		public void LEParentDad_MovementAnimatorController()
		{
			LE_MBA_Running.LEParent_RunningController();

			LE_MBA_Jumping.LEParent_JumpingController();

			LE_MBA_Turning.LEParent_TurningController();	

			LE_MBA_Strafe.LEParent_StrafingController();
		}
	}
}