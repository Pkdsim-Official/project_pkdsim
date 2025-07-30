using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.SittingTo
{
	public class GARCParentMom_SittingTo : MonoBehaviour 
	{
		private GARCParentMom_SittingToStartWalking GarchompParentMomSittingToStartWalking;
		private GARCParentMom_SittingToStanding GarchompParentMomSittingToStanding;
		public void GARCParentMom_SittingToController()
		{
			GARCParentMom_SittingToStartWalking();
			GARCParentMom_SittingToStanding();
		}
		private void GARCParentMom_SittingToStartWalking()
		{
			GarchompParentMomSittingToStartWalking.GARCParentMom_SittingToStartWalkingController();
		}
		private void GARCParentMom_SittingToStanding()
		{
			GarchompParentMomSittingToStanding.GARCParentMom_SittingToStandingController();
		}

	}
}