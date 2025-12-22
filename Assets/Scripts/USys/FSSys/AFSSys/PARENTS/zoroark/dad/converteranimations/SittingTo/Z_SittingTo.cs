using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.SittingTo
{
	public class ZParentDad_SittingTo : MonoBehaviour 
	{
		private ZParentDad_SittingToStartWalking ZoroarkParentDadSittingToStartWalking;
		private ZParentDad_SittingToStanding ZoroarkParentDadSittingToStanding;
		public void ZParentDad_SittingToController()
		{
			ZParentDad_SittingToStartWalking();
			ZParentDad_SittingToStanding();
		}
		private void ZParentDad_SittingToStartWalking()
		{
			ZoroarkParentDadSittingToStartWalking.ZParentDad_SittingToStartWalkingController();
		}
		private void ZParentDad_SittingToStanding()
		{
			ZoroarkParentDadSittingToStanding.ZParentDad_SittingToStandingController();
		}

	}
}