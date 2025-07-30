using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo
{
	public class SYLParentMom_SittingTo : MonoBehaviour 
	{
		private SYLParentMom_SittingToStartWalking SylveonParentMomSittingToStartWalking;
		private SYLParentMom_SittingToStanding SylveonParentMomSittingToStanding;
		public void SYLParentMom_SittingToController()
		{
			SYLParentMom_SittingToStartWalking();
			SYLParentMom_SittingToStanding();
		}
		private void SYLParentMom_SittingToStartWalking()
		{
			SylveonParentMomSittingToStartWalking.SYLParentMom_SittingToStartWalkingController();
		}
		private void SYLParentMom_SittingToStanding()
		{
			SylveonParentMomSittingToStanding.SYLParentMom_SittingToStandingController();
		}

	}
}