using project_pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.WalkingTo
{
	public class LUNA_WalkingTo : MonoBehaviour 
	{
		private LUNA_WalkingToSitting Lunala_WalkingToSitting;
		private LUNA_WalkingToStanding Lunala_WalkingToStanding;
		public void LUNA_WalkingToController()
		{
			LUNA_WalkingToSitting();
			LUNA_WalkingToStanding();
		}
		private void LUNA_WalkingToSitting()
		{
			Lunala_WalkingToSitting.LUNA_WalkingToSittingController();
		}
		private void LUNA_WalkingToStanding()
		{
			Lunala_WalkingToStanding.LUNA_WalkingToStandingController();
		}
	}
}