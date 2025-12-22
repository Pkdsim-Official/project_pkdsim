using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.IdleTo
{
	public class PHParentDad_IdleTo : MonoBehaviour 
	{
		private PHParentDad_IdleToRun PheromosaIdleToRun;
		private PHParentDad_IdleToWalk PheromosaIdleToWalk;
		public void PHParentDad_IdleToController()
		{
			Load_PHParentDad_idleToRun();
			Load_PHParentDad_idleToWalk();
		}
		private void Load_PHParentDad_idleToRun()
		{
			PheromosaIdleToRun.PHParentDad_IdleToRunController();
		}
		private void Load_PHParentDad_idleToWalk()
		{
			PheromosaIdleToWalk.PHParentDad_IdleToWalkController();
		}
	}
}