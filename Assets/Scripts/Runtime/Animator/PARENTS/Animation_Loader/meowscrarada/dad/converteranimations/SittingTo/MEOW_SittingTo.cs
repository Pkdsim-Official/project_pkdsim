using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.SittingTo
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