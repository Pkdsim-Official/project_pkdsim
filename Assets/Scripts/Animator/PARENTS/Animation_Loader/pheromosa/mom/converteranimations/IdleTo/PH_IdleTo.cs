using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.IdleTo
{
	public class PHParentMom_IdleTo : MonoBehaviour 
	{
		private PHParentMom_IdleToRun PheromosaParentMomIdleToRun;
		private PHParentMom_IdleToWalk PheromosaParentMomIdleToWalk;

		public void PHParentMom_IdleToController()
		{
			Load_PHParentMom_idleToRun();
			Load_PHParentMom_idleToWalk();
		}
		private void Load_PHParentMom_idleToRun()
		{
			PheromosaParentMomIdleToRun.PHParentMom_IdleToRunController();
		}
		private void Load_PHParentMom_idleToWalk()
		{
			PheromosaParentMomIdleToWalk.PHParentMom_IdleToWalkController();
		}
	}
}