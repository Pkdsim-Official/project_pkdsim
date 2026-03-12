using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Dragapult.converteranimations.SittingTo
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