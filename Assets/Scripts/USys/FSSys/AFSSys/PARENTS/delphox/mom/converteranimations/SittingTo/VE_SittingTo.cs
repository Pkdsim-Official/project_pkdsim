using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.converteranimations.SittingTo
{
	public class DLParentMom_SittingTo : MonoBehaviour 
	{
		private DLParentMom_SittingToStartWalking DelphoxParentMomSittingToStartWalking;
		private DLParentMom_SittingToStanding DelphoxParentMomSittingToStanding;
		public void DLParentMom_SittingToController()
		{
			DLParentMom_SittingToStartWalking();
			DLParentMom_SittingToStanding();
		}
		private void DLParentMom_SittingToStartWalking()
		{
			DelphoxParentMomSittingToStartWalking.DLParentMom_SittingToStartWalkingController();
		}
		private void DLParentMom_SittingToStanding()
		{
			DelphoxParentMomSittingToStanding.DLParentMom_SittingToStandingController();
		}

	}
}