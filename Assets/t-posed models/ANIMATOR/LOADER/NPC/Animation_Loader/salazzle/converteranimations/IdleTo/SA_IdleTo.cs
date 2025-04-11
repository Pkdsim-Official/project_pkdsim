using project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations.IdleTo
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