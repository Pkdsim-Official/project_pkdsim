using project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo
{
	public class ZIdleTo : MonoBehaviour 
	{
		private ZIdleToRun ZoroarkIdleToRun;
		private ZIdleToWalk ZoroarkIdleToWalk;
		public void ZIdleToController()
		{
			Load_ZidleToRun();
			Load_ZidleToWalk();
		}
		private void Load_ZidleToRun()
		{
			ZoroarkIdleToRun.ZIdleToRunController();
		}
		private void Load_ZidleToWalk()
		{
			ZoroarkIdleToWalk.ZIdleToWalkController();
		}
	}
}