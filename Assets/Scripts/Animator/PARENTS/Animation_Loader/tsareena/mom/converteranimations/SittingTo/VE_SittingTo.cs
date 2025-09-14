using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.SittingTo
{
	public class TParentMom_SittingTo : MonoBehaviour 
	{
		private TParentMom_SittingToStartWalking TsareenaParentMomSittingToStartWalking;
		private TParentMom_SittingToStanding TsareenaParentMomSittingToStanding;
		public void TParentMom_SittingToController()
		{
			TParentMom_SittingToStartWalking();
			TParentMom_SittingToStanding();
		}
		private void TParentMom_SittingToStartWalking()
		{
			TsareenaParentMomSittingToStartWalking.TParentMom_SittingToStartWalkingController();
		}
		private void TParentMom_SittingToStanding()
		{
			TsareenaParentMomSittingToStanding.TParentMom_SittingToStandingController();
		}

	}
}