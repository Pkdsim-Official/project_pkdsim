using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations.IdleTo
{
	public class PR_IdleTo : MonoBehaviour 
	{
		private PR_IdleToRun Primarina_IdleToRun;
		private PR_IdleToWalk Primarina_IdleToWalk;
		public void PR_IdleToController()
		{
			Load_PR_IdleToRun();
			Load_PR_IdleToWalk();
		}
		private void Load_PR_IdleToRun()
		{
			Primarina_IdleToRun.PR_IdleToRunController();
		}
		private void Load_PR_IdleToWalk()
		{
			Primarina_IdleToWalk.PR_IdleToWalkController();
		}
	}
}