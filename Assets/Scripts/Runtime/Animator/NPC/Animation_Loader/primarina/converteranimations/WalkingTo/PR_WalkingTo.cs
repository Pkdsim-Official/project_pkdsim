using Project_Pkdsim.ANIMATOR.Npcs.Primarina.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Primarina.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Primarina.converteranimations.WalkingTo
{
	public class PR_WalkingTo : MonoBehaviour 
	{
		private PR_WalkingToStanding Primarina_WalkingToStanding;
		private PR_WalkingToSitting Primarina_WalkingToSitting;
		public void PR_WalkingToController()
		{
			Load_PR_WalkingToStanding();
			Load_PR_WalkingToWSitting();
		}
		private void Load_PR_WalkingToStanding()
		{
			Primarina_WalkingToStanding.PR_WalkingToStandingController();
		}
		private void Load_PR_WalkingToWSitting()
		{
			Primarina_WalkingToSitting.PR_WalkingToSittingController();
		}
	}
}