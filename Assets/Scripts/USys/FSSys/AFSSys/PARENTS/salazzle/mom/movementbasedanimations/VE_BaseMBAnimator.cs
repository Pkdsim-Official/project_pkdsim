using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations
{
	public class SalazzleParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private SParentMom_Jumping SA_MBA_Jumping;
		
		private SParentMom_Running SA_MBA_Running;


		private SParentMom_Turning SA_MBA_Turning;

		private SParentMom_Strafing SA_MBA_Strafe;

		public void SParentMom_MovementAnimatorController()
		{
			SA_MBA_Running.SParentMom_RunningController();

			SA_MBA_Jumping.SParentMom_JumpingController();

			SA_MBA_Turning.SParentMom_TurningController();	

			SA_MBA_Strafe.SParentMom_StrafingController();
		}
	}
}