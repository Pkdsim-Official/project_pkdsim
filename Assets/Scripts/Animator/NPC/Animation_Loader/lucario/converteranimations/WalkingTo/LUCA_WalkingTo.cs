using project_pkdsim.ANIMATOR.Npcs.Lucario.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Npcs.Lucario.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lucario.converteranimations.WalkingTo
{
	public class LUCA_WalkingTo : MonoBehaviour 
	{
		private LUCA_WalkingToStanding Lucario_WalkingToStanding;
		private LUCA_WalkingToSitting Lucario_WalkingToSitting;
		public void LUCA_WalkingToController()
		{
			Load_LUCA_WalkingToStanding();
			Load_LUCA_WalkingToWSitting();
		}
		private void Load_LUCA_WalkingToStanding()
		{
			Lucario_WalkingToStanding.LUCA_WalkingToStandingController();
		}
		private void Load_LUCA_WalkingToWSitting()
		{
			Lucario_WalkingToSitting.LUCA_WalkingToSittingController();
		}
	}
}