using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Beedrill.converteranimations.WalkingTo
{
	public class BE_WalkingTo : MonoBehaviour 
	{
		private BE_WalkingToStanding Beedrill_WalkingToStanding;
		private BE_WalkingToSitting Beedrill_WalkingToSitting;
		public void BE_WalkingToController()
		{
			Load_BE_WalkingToStanding();
			Load_BE_WalkingToWSitting();
		}
		private void Load_BE_WalkingToStanding()
		{
			Beedrill_WalkingToStanding.BE_WalkingToStandingController();
		}
		private void Load_BE_WalkingToWSitting()
		{
			Beedrill_WalkingToSitting.BE_WalkingToSittingController();
		}
	}
}