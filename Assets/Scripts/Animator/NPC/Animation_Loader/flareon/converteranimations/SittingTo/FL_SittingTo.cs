using project_pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.SittingTo
{
	public class FL_SittingTo : MonoBehaviour 
	{
		private FL_SittingToStartWalking FL_sittingToStartWalking;
		private FL_SittingToStanding FL_sittingToStanding;
		
		public void FL_SittingToController()
		{
			Load_FL_SittingToStanding();
			Load_FL_SittingToStartWalking();
		}
		private void Load_FL_SittingToStanding()
		{
			FL_sittingToStanding.FL_SittingToStandingController();
		}
		private void Load_FL_SittingToStartWalking()
		{
			FL_sittingToStartWalking.FL_SittingToStartWalkingController();
		}
	}
}