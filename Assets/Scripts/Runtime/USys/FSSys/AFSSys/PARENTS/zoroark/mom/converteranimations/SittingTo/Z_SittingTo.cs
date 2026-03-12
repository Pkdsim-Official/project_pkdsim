using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.SittingTo
{
	public class ZParentMom_SittingTo : MonoBehaviour 
	{
		private ZParentMom_SittingToStartWalking ZoroarkParentMomSittingToStartWalking;
		private ZParentMom_SittingToStanding ZoroarkParentMomSittingToStanding;
		public void ZParentMom_SittingToController()
		{
			ZParentMom_SittingToStartWalking();
			ZParentMom_SittingToStanding();
		}
		private void ZParentMom_SittingToStartWalking()
		{
			ZoroarkParentMomSittingToStartWalking.ZParentMom_SittingToStartWalkingController();
		}
		private void ZParentMom_SittingToStanding()
		{
			ZoroarkParentMomSittingToStanding.ZParentMom_SittingToStandingController();
		}

	}
}