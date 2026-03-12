using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations
{
	public class ZoroarkParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private ZParentDad_Jumping ZoroarkParentDad_MBA_Jumping;
		
		private ZParentDad_Running ZoroarkParentDad_MBA_Running;


		private ZParentDad_Turning ZoroarkParentDad_MBA_Turning;

		private ZParentDad_Strafing ZoroarkParentDad_MBA_Strafe;

		public void ZParentDad_MovementAnimatorController()
		{
			ZoroarkParentDad_MBA_Running.ZParentDad_RunningController();

			ZoroarkParentDad_MBA_Jumping.ZParentDad_JumpingController();

			ZoroarkParentDad_MBA_Turning.ZParentDad_TurningController();	

			ZoroarkParentDad_MBA_Strafe.ZParentDad_StrafingController();
		}
	}
}