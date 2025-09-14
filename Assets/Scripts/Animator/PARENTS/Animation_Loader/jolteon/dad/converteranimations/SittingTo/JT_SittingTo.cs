using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo
{
	public class JTParentDad_SittingTo : MonoBehaviour 
	{
		private JTParentDad_SittingToStartWalking JTParentDadsittingToStartWalking;
		private JTParentDad_SittingToStanding JTParentDadsittingToStanding;
		public void JTParentDad_SittingToController()
		{
			JTParentDad_SittingToStartWalking();
			JTParentDad_SittingToStanding();
		}
		private void JTParentDad_SittingToStartWalking()
		{
			JTParentDadsittingToStartWalking.JTParentDad_SittingToStartWalkingController();
		}
		private void JTParentDad_SittingToStanding()
		{
			JTParentDadsittingToStanding.JTParentDad_SittingToStandingController();
		}
	}
}