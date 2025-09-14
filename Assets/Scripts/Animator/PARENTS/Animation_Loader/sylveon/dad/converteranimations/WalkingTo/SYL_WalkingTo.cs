using project_pkdsim.ANIMATOR.Parents.Sylveon.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Dad.converteranimations.WalkingTo
{
	public class SYLParentDad_WalkingTo : MonoBehaviour 
	{
		private SYLParentDad_WalkingToSitting SylveonParentDadWalkingToSitting;
		private SYLParentDad_WalkingToStanding SylveonParentDadWalkingToStanding;
		public void SYLParentDad_WalkingToController()
		{
			SYLParentDad_WalkingToSitting();
			SYLParentDad_WalkingToStanding();
		}
		private void SYLParentDad_WalkingToSitting()
		{
			SylveonParentDadWalkingToSitting.SYLParentDad_WalkingToSittingController();
		}
		private void SYLParentDad_WalkingToStanding()
		{
			SylveonParentDadWalkingToStanding.SYLParentDad_WalkingToStandingController();
		}
	}
}