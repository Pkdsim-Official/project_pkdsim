using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.Mom.converteranimations.IdleTo
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