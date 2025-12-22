using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.SittingTo
{
	public class LUNAParentMom_SittingTo : MonoBehaviour 
	{
		private LUNAParentMom_SittingToStartWalking LunalaParentMomSittingToStartWalking;
		private LUNAParentMom_SittingToStanding LunalaParentMomSittingToStanding;
		public void LUNAParentMom_SittingToController()
		{
			LUNAParentMom_SittingToStartWalking();
			LUNAParentMom_SittingToStanding();
		}
		private void LUNAParentMom_SittingToStartWalking()
		{
			LunalaParentMomSittingToStartWalking.LUNAParentMom_SittingToStartWalkingController();
		}
		private void LUNAParentMom_SittingToStanding()
		{
			LunalaParentMomSittingToStanding.LUNAParentMom_SittingToStandingController();
		}

	}
}