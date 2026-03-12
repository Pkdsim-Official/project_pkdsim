using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.converteranimations.IdleTo
{
	public class SA_IdleTo : MonoBehaviour 
	{
		private SA_IdleToRun Salazzle_IdleToRun;
		private SA_IdleToWalk Salazzle_IdleToWalk;
		public void SA_IdleToController()
		{
			SA_IdleToRun();
			SA_IdleToWalk();
		}
		private void SA_IdleToRun()
		{
			Salazzle_IdleToRun.SA_IdleToRunController();
		}
		private void SA_IdleToWalk()
		{
			Salazzle_IdleToWalk.SA_IdleToWalkController();
		}
	}
}