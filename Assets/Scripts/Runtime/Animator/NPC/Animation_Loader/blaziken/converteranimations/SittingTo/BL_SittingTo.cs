using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Blaziken.converteranimations.SittingTo
{
	public class BL_SittingTo : MonoBehaviour 
	{
		private BL_SittingToStartWalking Blaziken_SittingToStartWalking;
		private BL_SittingToStanding Blaziken_SittingToStanding;
		public void BL_SittingToController()
		{
			BL_SittingToStartWalking();
			BL_SittingToStanding();
		}
		private void BL_SittingToStartWalking()
		{
			Blaziken_SittingToStartWalking.BL_SittingToStartWalkingController();
		}
		private void BL_SittingToStanding()
		{
			Blaziken_SittingToStanding.BL_SittingToStandingController();
		}

	}
}