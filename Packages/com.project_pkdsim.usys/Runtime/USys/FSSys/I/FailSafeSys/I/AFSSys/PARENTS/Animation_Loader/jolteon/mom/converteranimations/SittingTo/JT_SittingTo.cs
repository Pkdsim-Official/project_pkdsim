using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.SittingTo
{
	public class JTParentMom_SittingTo : MonoBehaviour 
	{
		private JTParentMom_SittingToStartWalking JolteonParentMom_SittingToStartWalking;
		private JTParentMom_SittingToStanding JolteonParentMom_SittingToStanding;
		public void JTParentMom_SittingToController()
		{
			Load_JTParentMom_SittingToStartWalking();
			Load_JTParentMom_SittingToStanding();
		}
		private void Load_JTParentMom_SittingToStartWalking()
		{
			JolteonParentMom_SittingToStartWalking.JTParentMom_SittingToStartWalkingController();
		}
		private void Load_JTParentMom_SittingToStanding()
		{
			JolteonParentMom_SittingToStanding.JTParentMom_SittingToStandingController();
		}
	}
}