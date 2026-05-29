using project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.converteranimations.IdleTo
{
	public class SA_IdleTo : MonoBehaviour 
	{
		private SA_IdleToRun IdleToRun;
		private SA_IdleToWalk IdleToWalk;
		public void SA_IdleToController()
		{
			SA_IdleToRun();
			SA_IdleToWalk();
		}
		private void SA_IdleToRun()
		{
			IdleToRun.SA_IdleToRunController();
		}
		private void SA_IdleToWalk()
		{
			IdleToWalk.SA_IdleToWalkController();
		}
	}
}