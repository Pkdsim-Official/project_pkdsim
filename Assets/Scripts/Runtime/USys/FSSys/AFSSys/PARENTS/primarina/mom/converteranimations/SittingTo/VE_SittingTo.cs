using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.SittingTo
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