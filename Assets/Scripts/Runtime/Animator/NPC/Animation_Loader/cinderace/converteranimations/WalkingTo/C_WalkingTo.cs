using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Cinderace.converteranimations.WalkingTo
{
	public class C_WalkingTo : MonoBehaviour 
	{
		private C_WalkingToSitting Cinderace_WalkingToSitting;
		private C_WalkingToStanding Cinderace_WalkingToStanding;
		public void C_WalkingToController()
		{
			C_WalkingToStartWalking();
			C_WalkingToStanding();
		}
		private void C_WalkingToStartWalking()
		{
			Cinderace_WalkingToSitting.C_WalkingToSittingController();
		}
		private void C_WalkingToStanding()
		{
			Cinderace_WalkingToStanding.C_WalkingToStandingController();
		}
	}
}