using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.SittingTo
{
	public class PRParentMom_SittingTo : MonoBehaviour 
	{
		private PRParentMom_SittingToStartWalking PrimarinaParentMomSittingToStartWalking;
		private PRParentMom_SittingToStanding PrimarinaParentMomSittingToStanding;
		public void PRParentMom_SittingToController()
		{
			PRParentMom_SittingToStartWalking();
			PRParentMom_SittingToStanding();
		}
		private void PRParentMom_SittingToStartWalking()
		{
			PrimarinaParentMomSittingToStartWalking.PRParentMom_SittingToStartWalkingController();
		}
		private void PRParentMom_SittingToStanding()
		{
			PrimarinaParentMomSittingToStanding.PRParentMom_SittingToStandingController();
		}

	}
}