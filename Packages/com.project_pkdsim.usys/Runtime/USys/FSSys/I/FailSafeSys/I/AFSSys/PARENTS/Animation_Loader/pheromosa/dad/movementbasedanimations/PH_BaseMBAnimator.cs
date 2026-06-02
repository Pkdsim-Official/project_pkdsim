using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations
{
	public class PheromosaParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private PHParent_Jumping PheromosaParentDad_MBA_Jumping;
		
		private PHParent_Running PheromosaParentDad_MBA_Running;


		private PHParent_Turning PheromosaParentDad_MBA_Turning;

		private PHParent_Strafing PheromosaParentDad_MBA_Strafe;

		public void PHMovementAnimatorController()
		{
			PheromosaParentDad_MBA_Running.PHParent_RunningController();

			PheromosaParentDad_MBA_Jumping.PHParent_JumpingController();

			PheromosaParentDad_MBA_Turning.PHParent_TurningController();	

			PheromosaParentDad_MBA_Strafe.PHParent_StrafingController();
		}
	}
}