using project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo
{
	public class SA_IdleTo : MonoBehaviour 
	{
		private SA_IdleToRun SalazzleParentMom_IdleToRun;
		private SA_IdleToWalk SalazzleParentMom_IdleToWalk;
		public void SA_IdleToController()
		{
			SA_IdleToRun();
			SA_IdleToWalk();
		}
		private void SA_IdleToRun()
		{
			SalazzleParentMom_IdleToRun.SA_IdleToRunController();
		}
		private void SA_IdleToWalk()
		{
			SalazzleParentMom_IdleToWalk.SA_IdleToWalkController();
		}
	}
}