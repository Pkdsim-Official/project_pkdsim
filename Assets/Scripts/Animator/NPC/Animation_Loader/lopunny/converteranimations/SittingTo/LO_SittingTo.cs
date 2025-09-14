using project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.SittingTo
{
	public class LO_SittingTo : MonoBehaviour 
	{
		private LO_SittingToStartWalking LopunnysittingToStartWalking;
		private LO_SittingToStanding LopunnysittingToStanding;
		public void LO_SittingToController()
		{
			LO_SittingToStartWalking();
			LO_SittingToStanding();
		}
		private void LO_SittingToStartWalking()
		{
			LopunnysittingToStartWalking.LO_SittingToStartWalkingController();
		}
		private void LO_SittingToStanding()
		{
			LopunnysittingToStanding.LO_SittingToStandingController();
		}

	}
}