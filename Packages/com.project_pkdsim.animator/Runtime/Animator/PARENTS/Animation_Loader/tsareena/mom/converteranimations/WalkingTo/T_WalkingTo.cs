using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo.WalkingToStanding;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo.WalkingToSitting;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo
{
	public class TParentMom_WalkingTo : MonoBehaviour 
	{
		private TParentMom_WalkingToSitting TsareenaWalkingToSitting;
		private TParentMom_WalkingToStanding TsareenaWalkingToStanding;
		public void TParentMom_WalkingToController()
		{
			TParentMom_WalkingToSitting();
			TParentMom_WalkingToStanding();
		}
		private void TParentMom_WalkingToSitting()
		{
			TsareenaWalkingToSitting.TParentMom_WalkingToSittingController();
		}
		private void TParentMom_WalkingToStanding()
		{
			TsareenaWalkingToStanding.TParentMom_WalkingToStandingController();
		}
	}
}