using Project_Pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.SittingTo
{
	public class DL_SittingTo : MonoBehaviour 
	{
		private DL_SittingToStartWalking DelphoxsittingToStartWalking;
		private DL_SittingToStanding DelphoxsittingToStanding;
		public void DL_SittingToController()
		{
			DL_SittingToStartWalking();
			DL_SittingToStanding();
		}
		private void DL_SittingToStartWalking()
		{
			DelphoxsittingToStartWalking.DL_SittingToStartWalkingController();
		}
		private void DL_SittingToStanding()
		{
			DelphoxsittingToStanding.DL_SittingToStandingController();
		}

	}
}