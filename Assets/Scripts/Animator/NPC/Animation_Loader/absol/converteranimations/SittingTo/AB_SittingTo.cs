using project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.SittingTo
{
	public class ABSittingTo : MonoBehaviour 
	{
		private ABSittingToStartWalking AbsolsittingToStartWalking;
		private ABSittingToStanding AbsolsittingToStanding;
		public void ABSittingToController()
		{
			ABSittingToStartWalking();
			ABSittingToStanding();
		}
		private void ABSittingToStartWalking()
		{
			AbsolsittingToStartWalking.ABSittingToStartWalkingController();
		}
		private void ABSittingToStanding()
		{
			AbsolsittingToStanding.ABSittingToStandingController();
		}

	}
}