using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.SittingTo
{
	public class JTParentMom_SittingTo : MonoBehaviour 
	{
		private JTParentMom_SittingToStartWalking JolteonParentMomSittingToStartWalking;
		private JTParentMom_SittingToStanding JolteonParentMomSittingToStanding;
		public void JTParentMom_SittingToController()
		{
			JTParentMom_SittingToStartWalking();
			JTParentMom_SittingToStanding();
		}
		private void JTParentMom_SittingToStartWalking()
		{
			JolteonParentMomSittingToStartWalking.JTParentMom_SittingToStartWalkingController();
		}
		private void JTParentMom_SittingToStanding()
		{
			JolteonParentMomSittingToStanding.JTParentMom_SittingToStandingController();
		}

	}
}