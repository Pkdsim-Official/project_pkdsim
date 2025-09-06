using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.IdleTo
{
	public class PHIdleTo : MonoBehaviour 
	{
		private PHIdleToRun PheromosaIdleToRun;
		private PHIdleToWalk PheromosaIdleToWalk;
		public void PH_IdleToController()
		{
			Load_PHidleToRun();
			Load_PHidleToWalk();
		}
		private void Load_PHidleToRun()
		{
			PheromosaIdleToRun.PHIdleToRunController();
		}
		private void Load_PHidleToWalk()
		{
			PheromosaIdleToWalk.PHIdleToWalkController();
		}
	}
}