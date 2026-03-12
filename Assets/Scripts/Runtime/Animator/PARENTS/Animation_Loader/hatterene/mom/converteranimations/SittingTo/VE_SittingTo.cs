using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.SittingTo
{
	public class HATParentMom_SittingTo : MonoBehaviour 
	{
		private HATParentMom_SittingToStartWalking HattereneParentMomSittingToStartWalking;
		private HATParentMom_SittingToStanding HattereneParentMomSittingToStanding;
		public void HATParentMom_SittingToController()
		{
			HATParentMom_SittingToStartWalking();
			HATParentMom_SittingToStanding();
		}
		private void HATParentMom_SittingToStartWalking()
		{
			HattereneParentMomSittingToStartWalking.HATParentMom_SittingToStartWalkingController();
		}
		private void HATParentMom_SittingToStanding()
		{
			HattereneParentMomSittingToStanding.HATParentMom_SittingToStandingController();
		}

	}
}