using Project_Pkdsim.ANIMATOR.Npcs.Zoroark.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Zoroark.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Zoroark.converteranimations.WalkingTo
{
	public class Z_WalkingTo : MonoBehaviour 
	{
		private Z_WalkingToStanding Zoroark_WalkingToStanding;
		private Z_WalkingToSitting Zoroark_WalkingToSitting;
		
		public void Z_WalkingToController() 
		{
			Load_Z_WalkingToStandingController();
			Load_Z_WalkingToSittingController();
		}

		private void Load_Z_WalkingToStandingController()
		{
			Zoroark_WalkingToStanding.Z_WalkingToStandingController();
		}
		
		private void Load_Z_WalkingToSittingController()
		{
			Zoroark_WalkingToSitting.Z_WalkingToSittingController();
		}
	}
}