using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.converteranimations.WalkingTo
{
		public class JTParentMom_WalkingTo : MonoBehaviour 
	{
		private JTParentMom_WalkingToSitting JolteonParentMomWalkingToSitting;
		private JTParentMom_WalkingToStanding JolteonParentMomWalkingToStanding;
		public void JTParentMom_WalkingToController()
		{
			JTParentMom_WalkingToStartWalking();
			JTParentMom_WalkingToStanding();
		}
		private void JTParentMom_WalkingToStartWalking()
		{
			JolteonParentMomWalkingToSitting.JTParentMom_WalkingToSittingController();
		}
		private void JTParentMom_WalkingToStanding()
		{
			JolteonParentMomWalkingToStanding.JTParentMom_WalkingToStandingController();
		}
	}
}