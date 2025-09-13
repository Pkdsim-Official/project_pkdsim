using project_pkdsim.ANIMATOR.Parents.Cinderace.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Cinderace.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.converteranimations.SittingTo
{
	public class C_SittingTo : MonoBehaviour 
	{
		private C_SittingToStartWalking CinderaceSittingToStartWalking;
		private C_SittingToStanding CinderaceSittingToStanding;
		public void C_SittingToController()
		{
			C_SittingToStartWalking();
			C_SittingToStanding();
		}
		private void C_SittingToStartWalking()
		{
			CinderaceSittingToStartWalking.C_SittingToStartWalkingController();
		}
		private void C_SittingToStanding()
		{
			CinderaceSittingToStanding.C_SittingToStandingController();
		}
	}
}