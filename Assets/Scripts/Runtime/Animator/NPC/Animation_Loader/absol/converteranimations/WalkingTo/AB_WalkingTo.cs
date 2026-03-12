using Project_Pkdsim.ANIMATOR.Npcs.Absol.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Absol.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Absol.converteranimations.WalkingTo
{
	public class AB_WalkingTo : MonoBehaviour 
	{
		private AB_WalkingToSitting Absol_WalkingToSitting;
		private AB_WalkingToStanding Absol_WalkingToStanding;
		public void AB_WalkingToController()
		{
			AB_WalkingToStartWalking();
			AB_WalkingToStanding();
		}
		private void AB_WalkingToStartWalking()
		{
			Absol_WalkingToSitting.AB_WalkingToSittingController();
		}
		private void AB_WalkingToStanding()
		{
			Absol_WalkingToStanding.AB_WalkingToStandingController();
		}
	}
}