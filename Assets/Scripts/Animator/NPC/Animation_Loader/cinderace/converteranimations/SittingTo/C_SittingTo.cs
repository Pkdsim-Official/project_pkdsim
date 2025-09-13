using project_pkdsim.ANIMATOR.NPC.Cinderace.converteranimations._SittingTo._SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Cinderace.converteranimations._SittingTo._SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Cinderace.converteranimations._SittingTo
{
	public class C_SittingTo : MonoBehaviour 
	{
		private C_SittingToStartWalking Cinderace_SittingToStartWalking;
		private C_SittingToStanding Cinderace_SittingToStanding;
		public void C_SittingToController()
		{
			C_SittingToStartWalking();
			C_SittingToStanding();
		}
		private void C_SittingToStartWalking()
		{
			Cinderace_SittingToStartWalking.C_SittingToStartWalkingController();
		}
		private void C_SittingToStanding()
		{
			Cinderace_SittingToStanding.C_SittingToStandingController();
		}
	}
}