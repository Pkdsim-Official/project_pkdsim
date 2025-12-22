using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.SittingTo
{
	public class SParentMom_SittingTo : MonoBehaviour 
	{
		private SParentMom_SittingToStartWalking SalazzleParentMomSittingToStartWalking;
		private SParentMom_SittingToStanding SalazzleParentMomSittingToStanding;
		public void SParentMom_SittingToController()
		{
			SParentMom_SittingToStartWalking();
			SParentMom_SittingToStanding();
		}
		private void SParentMom_SittingToStartWalking()
		{
			SalazzleParentMomSittingToStartWalking.SParentMom_SittingToStartWalkingController();
		}
		private void SParentMom_SittingToStanding()
		{
			SalazzleParentMomSittingToStanding.SParentMom_SittingToStandingController();
		}

	}
}