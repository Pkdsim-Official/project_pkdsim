using project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo
{
	public class LOSittingTo : MonoBehaviour 
	{
		private LOSittingToStartWalking LopunnysittingToStartWalking;
		private LOSittingToStanding LopunnysittingToStanding;
		public void LOSittingToController()
		{
			LOSittingToStartWalking();
			LOSittingToStanding();
		}
		private void LOSittingToStartWalking()
		{
			LopunnysittingToStartWalking.LOSittingToStartWalkingController();
		}
		private void LOSittingToStanding()
		{
			LopunnysittingToStanding.LOSittingToStandingController();
		}

	}
}