using project_pkdsim.ANIMATOR.NPC.Lunala.converteranimations._SittingTo._SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Lunala.converteranimations._SittingTo._SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lunala.converteranimations._SittingTo
{
	public class LUNA_SittingTo : MonoBehaviour 
	{
		private LUNA_SittingToStartWalking LunalasittingToStartWalking;
		private LUNA_SittingToStanding LunalasittingToStanding;
		public void LUNA_SittingToController()
		{
			LUNA_SittingToStartWalking();
			LUNA_SittingToStanding();
		}
		private void LUNA_SittingToStartWalking()
		{
			LunalasittingToStartWalking.LUNA_SittingToStartWalkingController();
		}
		private void LUNA_SittingToStanding()
		{
			LunalasittingToStanding.LUNA_SittingToStandingController();
		}

	}
}