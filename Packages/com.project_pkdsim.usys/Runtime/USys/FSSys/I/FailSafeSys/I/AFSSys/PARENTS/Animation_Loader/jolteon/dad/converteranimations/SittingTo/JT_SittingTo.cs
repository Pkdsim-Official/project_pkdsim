using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo
{
	public class JTParentDad_SittingTo : MonoBehaviour 
	{
		private JTParentDad_SittingToStartWalking JTParentDad_SittingToStartWalking;
		private JTParentDad_SittingToStanding JTParentDad_SittingToStanding;
		public void JTParentDad_SittingToController()
		{
			Load_JTParentDad_SittingToStartWalking();
			Load_JTParentDad_SittingToStanding();
		}
		private void Load_JTParentDad_SittingToStartWalking()
		{
			JTParentDad_SittingToStartWalking.JTParentDad_SittingToStartWalkingController();
		}
		private void Load_JTParentDad_SittingToStanding()
		{
			JTParentDad_SittingToStanding.JTParentDad_SittingToStandingController();
		}
	}
}