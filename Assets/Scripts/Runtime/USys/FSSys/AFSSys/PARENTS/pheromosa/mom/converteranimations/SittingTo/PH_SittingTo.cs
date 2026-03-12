using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.SittingTo
{
	public class PHParentMom_SittingTo : MonoBehaviour 
	{
		private PHParentMom_SittingToStartWalking PheromosaParentMomSittingToStartWalking;
		private PHParentMom_SittingToStanding PheromosaParentMomSittingToStanding;
		public void PHParentMom_SittingToController()
		{
			PHParentMom_SittingToStartWalking();
			PHParentMom_SittingToStanding();
		}
		private void PHParentMom_SittingToStartWalking()
		{
			PheromosaParentMomSittingToStartWalking.PHParentMom_SittingToStartWalkingController();
		}
		private void PHParentMom_SittingToStanding()
		{
			PheromosaParentMomSittingToStanding.PHParentMom_SittingToStandingController();
		}

	}
}