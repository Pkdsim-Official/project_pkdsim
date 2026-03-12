using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.WalkingTo
{
		public class SYLParentMom_WalkingTo : MonoBehaviour 
	{
		private SYLParentMom_WalkingToSitting SylveonParentMomWalkingToSitting;
		private SYLParentMom_WalkingToStanding SylveonParentMomWalkingToStanding;
		public void SYLParentMom_WalkingToController()
		{
			SYLParentMom_WalkingToStartWalking();
			SYLParentMom_WalkingToStanding();
		}
		private void SYLParentMom_WalkingToStartWalking()
		{
			SylveonParentMomWalkingToSitting.SYLParentMom_WalkingToSittingController();
		}
		private void SYLParentMom_WalkingToStanding()
		{
			SylveonParentMomWalkingToStanding.SYLParentMom_WalkingToStandingController();
		}
	}
}