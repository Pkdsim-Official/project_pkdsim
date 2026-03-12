using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.SittingTo
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