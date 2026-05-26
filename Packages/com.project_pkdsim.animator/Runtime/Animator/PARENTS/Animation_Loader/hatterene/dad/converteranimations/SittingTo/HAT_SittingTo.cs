using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.SittingTo
{
	public class HATSittingTo : MonoBehaviour 
	{
		private HATSittingToStartWalking HatterenesittingToStartWalking;
		private HATSittingToStanding HatterenesittingToStanding;
		public void HATSittingToController()
		{
			HATSittingToStartWalking();
			HATSittingToStanding();
		}
		private void HATSittingToStartWalking()
		{
			HatterenesittingToStartWalking.HATSittingToStartWalkingController();
		}
		private void HATSittingToStanding()
		{
			HatterenesittingToStanding.HATSittingToStandingController();
		}
	}
}