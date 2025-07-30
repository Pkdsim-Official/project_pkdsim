using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo
{
	public class JTParentDad_WalkingTo : MonoBehaviour
	{
		private JTParentDad_WalkingToSitting JolteonParentDadWalkingToSitting;
		private JTParentDad_WalkingToStanding JolteonParentDadWalkingToStanding;
		public void JTParentDad_WalkingToController()
		{
			JTParentDad_WalkingToStartWalking();
			JTParentDad_WalkingToStanding();
		}
		private void JTParentDad_WalkingToStartWalking()
		{
			JolteonParentDadWalkingToSitting.JTParentDad_WalkingToSittingController();
		}
		private void JTParentDad_WalkingToStanding()
		{
			JolteonParentDadWalkingToStanding.JTParentDad_WalkingToStandingController();
		}
	}
}