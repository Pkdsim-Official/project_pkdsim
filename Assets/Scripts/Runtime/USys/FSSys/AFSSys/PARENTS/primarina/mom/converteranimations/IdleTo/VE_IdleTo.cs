using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.IdleTo
{
	public class PRParentMom_IdleTo : MonoBehaviour 
	{
		private PRParentMom_IdleToRun PrimarinaParentMomIdleToRun;
		private PRParentMom_IdleToWalk PrimarinaParentMomIdleToWalk;

		public void PRParentMom_IdleToController()
		{
			Load_PRParentMom_idleToRun();
			Load_PRParentMom_idleToWalk();
		}
		private void Load_PRParentMom_idleToRun()
		{
			PrimarinaParentMomIdleToRun.PRParentMom_IdleToRunController();
		}
		private void Load_PRParentMom_idleToWalk()
		{
			PrimarinaParentMomIdleToWalk.PRParentMom_IdleToWalkController();
		}
	}
}