using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.converteranimations.WalkingTo
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