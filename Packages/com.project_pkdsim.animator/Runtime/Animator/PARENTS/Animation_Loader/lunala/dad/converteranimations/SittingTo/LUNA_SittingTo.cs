using project_pkdsim.ANIMATOR.Parents.Lunala.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Lunala.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Dad.converteranimations.SittingTo
{
	public class LUNASittingTo : MonoBehaviour 
	{
		private LUNASittingToStartWalking LunalasittingToStartWalking;
		private LUNASittingToStanding LunalasittingToStanding;
		public void LUNASittingToController()
		{
			LUNASittingToStartWalking();
			LUNASittingToStanding();
		}
		private void LUNASittingToStartWalking()
		{
			LunalasittingToStartWalking.LUNASittingToStartWalkingController();
		}
		private void LUNASittingToStanding()
		{
			LunalasittingToStanding.LUNASittingToStandingController();
		}

	}
}