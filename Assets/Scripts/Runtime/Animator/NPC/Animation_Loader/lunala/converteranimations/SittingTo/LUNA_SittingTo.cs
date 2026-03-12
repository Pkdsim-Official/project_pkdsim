using Project_Pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.SittingTo
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