using project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations.SittingTo
{
	public class MEOWSittingTo : MonoBehaviour 
	{
		private MEOWSittingToStartWalking MeowscaradasittingToStartWalking;
		private MEOWSittingToStanding MeowscaradasittingToStanding;
		public void MEOWSittingToController()
		{
			MEOWSittingToStartWalking();
			MEOWSittingToStanding();
		}
		private void MEOWSittingToStartWalking()
		{
			MeowscaradasittingToStartWalking.MEOWSittingToStartWalkingController();
		}
		private void MEOWSittingToStanding()
		{
			MeowscaradasittingToStanding.MEOWSittingToStandingController();
		}

	}
}