using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo
{
		public class LUCAParentMom_WalkingTo : MonoBehaviour 
	{
		private LUCAParentMom_WalkingToSitting LucarioParentMomWalkingToSitting;
		private LUCAParentMom_WalkingToStanding LucarioParentMomWalkingToStanding;
		public void LUCAParentMom_WalkingToController()
		{
			LUCAParentMom_WalkingToStartWalking();
			LUCAParentMom_WalkingToStanding();
		}
		private void LUCAParentMom_WalkingToStartWalking()
		{
			LucarioParentMomWalkingToSitting.LUCAParentMom_WalkingToSittingController();
		}
		private void LUCAParentMom_WalkingToStanding()
		{
			LucarioParentMomWalkingToStanding.LUCAParentMom_WalkingToStandingController();
		}
	}
}