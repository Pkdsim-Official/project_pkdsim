using Project_Pkdsim.ANIMATOR.Parents.Absol.Dad.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Absol.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Absol.Dad.converteranimations.WalkingTo
{
	public class AB_WalkingTo : MonoBehaviour 
	{
		private AB_WalkingToSitting AbsolWalkingToSitting;
		private AB_WalkingToStanding AbsolWalkingToStanding;
		public void AB_WalkingToController()
		{
			AB_WalkingToStartWalking();
			AB_WalkingToStanding();
		}
		private void AB_WalkingToStartWalking()
		{
			AbsolWalkingToSitting.AB_WalkingToSittingController();
		}
		private void AB_WalkingToStanding()
		{
			AbsolWalkingToStanding.AB_WalkingToStandingController();
		}
	}
}