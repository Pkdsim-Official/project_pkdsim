using Project_Pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Delphox.converteranimations.WalkingTo
{
	public class DL_WalkingTo : MonoBehaviour 
	{
		private DL_WalkingToSitting Delphox_WalkingToSitting;
		private DL_WalkingToStanding Delphox_WalkingToStanding;
		public void DL_WalkingToController() 
		{
			Load_DL_WalkingToSitting();
			Load_DL_WalkingToStanding();
		}
		private void Load_DL_WalkingToStanding()
		{
			Delphox_WalkingToStanding.DL_WalkingToStandingController();
		}
		private void Load_DL_WalkingToSitting()
		{
			Delphox_WalkingToSitting.DL_WalkingToSittingController();
		}
	}
}