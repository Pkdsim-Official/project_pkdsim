using project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.WalkingTo
{
	public class SA_WalkingTo : MonoBehaviour 
	{
		private SA_WalkingToSitting SalazzleParentMom_WalkingToSitting;
		private SA_WalkingToStanding SalazzleParentMom_WalkingToStanding;
		public void SA_WalkingToController()
		{
			SA_WalkingToSitting();
			SA_WalkingToStanding();
		}
		private void SA_WalkingToSitting()
		{
			SalazzleParentMom_WalkingToSitting.SA_WalkingToSittingController();
		}
		private void SA_WalkingToStanding()
		{
			SalazzleParentMom_WalkingToStanding.SA_WalkingToStandingController();
		}
	}
}