using Project_Pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Salazzle.Mom.converteranimations.WalkingTo
{
		public class SParentMom_WalkingTo : MonoBehaviour 
	{
		private SParentMom_WalkingToSitting SalazzleParentMomWalkingToSitting;
		private SParentMom_WalkingToStanding SalazzleParentMomWalkingToStanding;
		public void SParentMom_WalkingToController()
		{
			SParentMom_WalkingToStartWalking();
			SParentMom_WalkingToStanding();
		}
		private void SParentMom_WalkingToStartWalking()
		{
			SalazzleParentMomWalkingToSitting.SParentMom_WalkingToSittingController();
		}
		private void SParentMom_WalkingToStanding()
		{
			SalazzleParentMomWalkingToStanding.SParentMom_WalkingToStandingController();
		}
	}
}