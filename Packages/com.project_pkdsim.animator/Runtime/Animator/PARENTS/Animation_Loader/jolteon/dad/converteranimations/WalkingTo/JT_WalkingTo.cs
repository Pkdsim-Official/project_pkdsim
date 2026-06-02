using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.WalkingTo
{
	public class JTParentDad_WalkingTo : MonoBehaviour 
	{
		private JTParentDad_WalkingToSitting JolteonParentDad_walkingtoSitting;
		private JTParentDad_WalkingToStanding JolteonParentDad_walkingtoStanding;
		public void JTParentDad_WalkingToController()
		{
			Load_JTParentDad_WalkingToSitting();
			Load_JTParentDad_WalkingToStanding();
		}
		private void Load_JTParentDad_WalkingToSitting()
		{
			JolteonParentDad_walkingtoSitting.JTParentDad_WalkingToSittingController();
		}
		private void Load_JTParentDad_WalkingToStanding()
		{
			JolteonParentDad_walkingtoStanding.JTParentDad_WalkingToStandingController();
		}
	}
}