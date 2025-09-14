using project_pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.WalkingTo.WalkingToStanding;
using project_pkdsim.ANIMATOR.Npcs.Tsareena.converteranimations.WalkingTo.WalkingToSitting;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Tsareena.converteranimations.WalkingTo
{
	public class T_WalkingTo : MonoBehaviour 
	{
		private T_WalkingToSitting Tsareena_WalkingToSitting;
		private T_WalkingToStanding Tsareena_WalkingToStanding;
		public void T_WalkingToController()
		{
			T_WalkingToSitting();
			T_WalkingToStanding();
		}
		private void T_WalkingToSitting()
		{
			Tsareena_WalkingToSitting.T_WalkingToSittingController();
		}
		private void T_WalkingToStanding()
		{
			Tsareena_WalkingToStanding.T_WalkingToStandingController();
		}
	}
}