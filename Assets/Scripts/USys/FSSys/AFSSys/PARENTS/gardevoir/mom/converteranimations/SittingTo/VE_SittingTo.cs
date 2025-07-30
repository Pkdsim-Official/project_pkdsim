using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.SittingTo
{
	public class GARDParentMom_SittingTo : MonoBehaviour 
	{
		private GARDParentMom_SittingToStartWalking GardevoirParentMomSittingToStartWalking;
		private GARDParentMom_SittingToStanding GardevoirParentMomSittingToStanding;
		public void GARDParentMom_SittingToController()
		{
			GARDParentMom_SittingToStartWalking();
			GARDParentMom_SittingToStanding();
		}
		private void GARDParentMom_SittingToStartWalking()
		{
			GardevoirParentMomSittingToStartWalking.GARDParentMom_SittingToStartWalkingController();
		}
		private void GARDParentMom_SittingToStanding()
		{
			GardevoirParentMomSittingToStanding.GARDParentMom_SittingToStandingController();
		}

	}
}