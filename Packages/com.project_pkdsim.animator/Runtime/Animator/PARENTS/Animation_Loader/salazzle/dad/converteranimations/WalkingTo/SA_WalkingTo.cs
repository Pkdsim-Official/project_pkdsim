using project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Salazzle.Dad.converteranimations.WalkingTo
{
	public class SA_WalkingTo : MonoBehaviour 
	{
		private SA_WalkingToSitting WalkingToSitting;
		private SA_WalkingToStanding WalkingToStanding;
		public void SA_WalkingToController()
		{
			SA_WalkingToSitting();
			SA_WalkingToStanding();
		}
		private void SA_WalkingToSitting()
		{
			WalkingToSitting.SA_WalkingToSittingController();
		}
		private void SA_WalkingToStanding()
		{
			WalkingToStanding.SA_WalkingToStandingController();
		}
	}
}