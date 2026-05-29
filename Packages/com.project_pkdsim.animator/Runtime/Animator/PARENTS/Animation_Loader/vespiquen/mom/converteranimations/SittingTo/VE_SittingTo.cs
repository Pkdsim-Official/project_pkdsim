using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo
{
	public class VESittingTo : MonoBehaviour 
	{
		private VESittingToStartWalking VespiquensittingToStartWalking;
		private VESittingToStanding VespiquensittingToStanding;
		public void VESittingToController()
		{
			VESittingToStartWalking();
			VESittingToStanding();
		}
		private void VESittingToStartWalking()
		{
			VespiquensittingToStartWalking.VESittingToStartWalkingController();
		}
		private void VESittingToStanding()
		{
			VespiquensittingToStanding.VESittingToStandingController();
		}

	}
}