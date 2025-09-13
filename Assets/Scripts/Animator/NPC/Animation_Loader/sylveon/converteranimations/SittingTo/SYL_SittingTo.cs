using project_pkdsim.ANIMATOR.NPC.Sylveon.converteranimations._SittingTo._SittingToStanding;
using project_pkdsim.ANIMATOR.NPC.Sylveon.converteranimations._SittingTo._SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Sylveon.converteranimations._SittingTo
{
	public class SYL_SittingTo : MonoBehaviour 
	{
		private SYL_SittingToStartWalking Sylveon_SittingToStartWalking;
		private SYL_SittingToStanding Sylveon_SittingToStanding;
		public void SYL_SittingToController()
		{
			Load_SYL_SittingToStartWalking();
			Load_SYL_SittingToStanding();
		}
		private void Load_SYL_SittingToStartWalking()
		{
			Sylveon_SittingToStartWalking.SYL_SittingToStartWalkingController();
		}
		private void Load_SYL_SittingToStanding()
		{
			Sylveon_SittingToStanding.SYL_SittingToStandingController();
		}
	}
}