using Project_Pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.SittingTo
{
	public class NOI_SittingTo : MonoBehaviour 
	{
		private NOI_SittingToStartWalking NoivernsittingToStartWalking;
		private NOI_SittingToStanding NoivernsittingToStanding;
		public void NOI_SittingToController()
		{
			NOI_SittingToStartWalking();
			NOI_SittingToStanding();
		}
		private void NOI_SittingToStartWalking()
		{
			NoivernsittingToStartWalking.NOI_SittingToStartWalkingController();
		}
		private void NOI_SittingToStanding()
		{
			NoivernsittingToStanding.NOI_SittingToStandingController();
		}
	}
}