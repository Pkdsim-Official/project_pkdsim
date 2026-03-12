using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.converteranimations.IdleTo
{
	public class BLParentMom_IdleTo : MonoBehaviour 
	{
		private BLParentMom_IdleToRun BlazikenParentMomIdleToRun;
		private BLParentMom_IdleToWalk BlazikenParentMomIdleToWalk;

		public void BLParentMom_IdleToController()
		{
			Load_BLParentMom_idleToRun();
			Load_BLParentMom_idleToWalk();
		}
		private void Load_BLParentMom_idleToRun()
		{
			BlazikenParentMomIdleToRun.BLParentMom_IdleToRunController();
		}
		private void Load_BLParentMom_idleToWalk()
		{
			BlazikenParentMomIdleToWalk.BLParentMom_IdleToWalkController();
		}
	}
}