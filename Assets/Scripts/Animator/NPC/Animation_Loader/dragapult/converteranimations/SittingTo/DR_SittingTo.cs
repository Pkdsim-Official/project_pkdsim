using project_pkdsim.ANIMATOR.NPC.Dragapult.converteranimations._SittingTo._SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Dragapult.converteranimations._SittingTo._SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Dragapult.converteranimations._SittingTo
{
	public class DR_SittingTo : MonoBehaviour 
	{
		private DR_SittingToStartWalking DragapultsittingToStartWalking;
		private DR_SittingToStanding DragapultsittingToStanding;
		public void DR_SittingToController()
		{
			DR_SittingToStartWalking();
			DR_SittingToStanding();
		}
		private void DR_SittingToStartWalking()
		{
			DragapultsittingToStartWalking.DR_SittingToStartWalkingController();
		}
		private void DR_SittingToStanding()
		{
			DragapultsittingToStanding.DR_SittingToStandingController();
		}
	}
}