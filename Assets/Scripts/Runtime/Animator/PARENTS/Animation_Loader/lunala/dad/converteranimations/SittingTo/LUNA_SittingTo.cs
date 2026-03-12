using Project_Pkdsim.ANIMATOR.Parents.Lunala.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Lunala.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lunala.converteranimations.SittingTo
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