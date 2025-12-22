using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.SittingTo
{
	public class CParentMom_SittingTo : MonoBehaviour 
	{
		private CParentMom_SittingToStartWalking CinderaceParentMomSittingToStartWalking;
		private CParentMom_SittingToStanding CinderaceParentMomSittingToStanding;
		public void CParentMom_SittingToController()
		{
			CParentMom_SittingToStartWalking();
			CParentMom_SittingToStanding();
		}
		private void CParentMom_SittingToStartWalking()
		{
			CinderaceParentMomSittingToStartWalking.CParentMom_SittingToStartWalkingController();
		}
		private void CParentMom_SittingToStanding()
		{
			CinderaceParentMomSittingToStanding.CParentMom_SittingToStandingController();
		}

	}
}