using Project_Pkdsim.ANIMATOR.Npcs.Salazzle.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Salazzle.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Salazzle.converteranimations.WalkingTo
{
	public class SA_WalkingTo : MonoBehaviour 
	{
		private SA_WalkingToSitting Salazzle_WalkingToSitting;
		private SA_WalkingToStanding Salazzle_WalkingToStanding;
		public void SA_WalkingToController()
		{
			SA_WalkingToSitting();
			SA_WalkingToStanding();
		}
		private void SA_WalkingToSitting()
		{
			Salazzle_WalkingToSitting.SA_WalkingToSittingController();
		}
		private void SA_WalkingToStanding()
		{
			Salazzle_WalkingToStanding.SA_WalkingToStandingController();
		}
	}
}