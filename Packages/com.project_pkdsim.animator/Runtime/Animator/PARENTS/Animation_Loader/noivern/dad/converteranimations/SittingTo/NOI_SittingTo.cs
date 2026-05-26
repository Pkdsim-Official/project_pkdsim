using project_pkdsim.ANIMATOR.Parents.Noivern.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Noivern.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.converteranimations.SittingTo
{
	public class NOISittingTo : MonoBehaviour 
	{
		private NOISittingToStartWalking NoivernsittingToStartWalking;
		private NOISittingToStanding NoivernsittingToStanding;
		public void NOISittingToController()
		{
			NOISittingToStartWalking();
			NOISittingToStanding();
		}
		private void NOISittingToStartWalking()
		{
			NoivernsittingToStartWalking.NOISittingToStartWalkingController();
		}
		private void NOISittingToStanding()
		{
			NoivernsittingToStanding.NOISittingToStandingController();
		}
	}
}