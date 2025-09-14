using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.WalkingTo
{
		public class FRParentMom_WalkingTo : MonoBehaviour 
	{
		private FRParentMom_WalkingToSitting FrostlassParentMomWalkingToSitting;
		private FRParentMom_WalkingToStanding FrostlassParentMomWalkingToStanding;
		public void FRParentMom_WalkingToController()
		{
			FRParentMom_WalkingToStartWalking();
			FRParentMom_WalkingToStanding();
		}
		private void FRParentMom_WalkingToStartWalking()
		{
			FrostlassParentMomWalkingToSitting.FRParentMom_WalkingToSittingController();
		}
		private void FRParentMom_WalkingToStanding()
		{
			FrostlassParentMomWalkingToStanding.FRParentMom_WalkingToStandingController();
		}
	}
}