using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.SittingTo
{
	public class JTParentDad_SittingTo : MonoBehaviour 
	{
		private JTParentDad_SittingToStartWalking JolteonParentDad_sittingtoStartWalking;
		private JTParentDad_SittingToStanding JolteonParentDad_sittingtoStanding;
		public void JTParentDad_SittingToController()
		{
			Load_JTParentDad_SittingToStartWalking();
			Load_JTParentDad_SittingToStanding();	
		}
		private void Load_JTParentDad_SittingToStartWalking()
		{
			JolteonParentDad_sittingtoStartWalking.JTParentDad_SittingToStartWalkingController();	
		}
		private void Load_JTParentDad_SittingToStanding()
		{
			JolteonParentDad_sittingtoStanding.JTParentDad_SittingToStandingController();
		}
	}
}