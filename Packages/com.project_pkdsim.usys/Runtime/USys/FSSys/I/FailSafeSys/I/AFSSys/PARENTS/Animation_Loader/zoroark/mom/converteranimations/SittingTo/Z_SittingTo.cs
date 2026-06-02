using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.SittingTo
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