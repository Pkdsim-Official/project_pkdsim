using project_pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations.SittingTo
{
	public class ABParentMom_SittingTo : MonoBehaviour 
	{
		private ABParentMom_SittingToStartWalking AbsolParentMomSittingToStartWalking;
		private ABParentMom_SittingToStanding AbsolParentMomSittingToStanding;
		public void ABParentMom_SittingToController()
		{
			ABParentMom_SittingToStartWalking();
			ABParentMom_SittingToStanding();
		}
		private void ABParentMom_SittingToStartWalking()
		{
			AbsolParentMomSittingToStartWalking.ABParentMom_SittingToStartWalkingController();
		}
		private void ABParentMom_SittingToStanding()
		{
			AbsolParentMomSittingToStanding.ABParentMom_SittingToStandingController();
		}

	}
}