using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.SittingTo
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