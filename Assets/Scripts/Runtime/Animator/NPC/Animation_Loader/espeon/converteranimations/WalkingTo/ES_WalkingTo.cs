using Project_Pkdsim.ANIMATOR.Npcs.Espeon.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Espeon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Espeon.converteranimations.WalkingTo
{
	public class ES_WalkingTo : MonoBehaviour 
	{
		private ES_WalkingToSitting ES_WalkingToSitting;
		private ES_WalkingToStanding ES_WalkingToStanding;
		public void ES_WalkingToController()
		{
			ES_WalkingToSitting.ES_WalkingToSittingController();
			ES_WalkingToStanding.ES_WalkingToStandingController();
		}
	}
}