using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.SittingTo
{
	public class BEParentDad_SittingTo : MonoBehaviour 
	{
		private BEParentDad_SittingToStartWalking BeedrillSittingToStartWalking;
		private BEParentDad_SittingToStanding BeedrillSittingToStanding;
		public void BEParentDad_SittingToController()
		{
			BEParentDad_SittingToStartWalking();
			BEParentDad_SittingToStanding();
		}
		private void BEParentDad_SittingToStartWalking()
		{
			BeedrillSittingToStartWalking.BEParentDad_SittingToStartWalkingController();
		}
		private void BEParentDad_SittingToStanding()
		{
			BeedrillSittingToStanding.BEParentDad_SittingToStandingController();
		}
	}
}