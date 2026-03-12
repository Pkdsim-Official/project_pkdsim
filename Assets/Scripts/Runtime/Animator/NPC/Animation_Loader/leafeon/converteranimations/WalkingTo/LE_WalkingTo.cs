using Project_Pkdsim.ANIMATOR.Npcs.Leafeon.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Leafeon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Leafeon.converteranimations.WalkingTo
{
	public class LE_WalkingTo : MonoBehaviour 
	{
		private LE_WalkingToSitting LE_WalkingToSitting;
		private LE_WalkingToStanding LE_WalkingToStanding;

		public void LE_WalkingToController()
		{
			Load_LE_WalkingToSitting();
			Load_LE_WalkingToStanding();
		}
		private void Load_LE_WalkingToSitting()
		{
			LE_WalkingToSitting.LE_WalkingToSittingController();
		}
		private void Load_LE_WalkingToStanding()
		{
			LE_WalkingToStanding.LE_WalkingToStandingController();
		}
	}
}