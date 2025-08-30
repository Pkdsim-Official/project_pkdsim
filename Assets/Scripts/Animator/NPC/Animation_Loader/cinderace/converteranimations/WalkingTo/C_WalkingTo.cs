using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo
{
	public class CWalkingTo : MonoBehaviour 
	{
		private CWalkingToSitting CinderaceWalkingToSitting;
		private CWalkingToStanding CinderaceWalkingToStanding;
		public void CWalkingToController()
		{
			CWalkingToStartWalking();
			CWalkingToStanding();
		}
		private void CWalkingToStartWalking()
		{
			CinderaceWalkingToSitting.CWalkingToSittingController();
		}
		private void CWalkingToStanding()
		{
			CinderaceWalkingToStanding.CWalkingToStandingController();
		}
	}
}