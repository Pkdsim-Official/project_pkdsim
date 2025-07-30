using project_pkdsim.ANIMATOR.NPC.Zoroark.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Zoroark.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Zoroark.converteranimations.SittingTo
{
	public class Z_SittingTo : MonoBehaviour 
	{
		private Z_SittingToStartWalking ZoroarksittingToStartWalking;
		private Z_SittingToStanding ZoroarksittingToStanding;
		public void Z_SittingToController()
		{
			Z_SittingToStartWalking();
			Z_SittingToStanding();
		}
		private void Z_SittingToStartWalking()
		{
			ZoroarksittingToStartWalking.Z_SittingToStartWalkingController();
		}
		private void Z_SittingToStanding()
		{
			ZoroarksittingToStanding.Z_SittingToStandingController();
		}

	}
}