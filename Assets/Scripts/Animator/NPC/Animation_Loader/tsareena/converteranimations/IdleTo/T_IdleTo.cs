using project_pkdsim.Models.ANIMATOR.NPC.Tsareena.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Tsareena.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Tsareena.converteranimations.IdleTo
{
	public class TIdleTo : MonoBehaviour 
	{
		private TIdleToRun TsareenaIdleToRun;
		private TIdleToWalk TsareenaIdleToWalk;
		public void TIdleToController()
		{
			Load_TidleToRun();
			Load_TidleToWalk();
		}
		private void Load_TidleToRun()
		{
			TsareenaIdleToRun.TIdleToRunController();
		}
		private void Load_TidleToWalk()
		{
			TsareenaIdleToWalk.TIdleToWalkController();
		}
	}
}