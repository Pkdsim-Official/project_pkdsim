using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.SittingTo
{
	public class PHParentDad_SittingTo : MonoBehaviour 
	{
		private PHParentDad_SittingToStartWalking PheromosaParentDadsittingToStartWalking;
		private PHParentDad_SittingToStanding PheromosaParentDadsittingToStanding;
		public void PHParentDad_SittingToController()
		{
			PHParentDad_SittingToStartWalking();
			PHParentDad_SittingToStanding();
		}
		private void PHParentDad_SittingToStartWalking()
		{
			PheromosaParentDadsittingToStartWalking.PHParentDad_SittingToStartWalkingController();
		}
		private void PHParentDad_SittingToStanding()
		{
			PheromosaParentDadsittingToStanding.PHParentDad_SittingToStandingController();
		}
	}
}