using project_pkdsim.ANIMATOR.Npcs.Jolteon.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Npcs.Jolteon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Jolteon.converteranimations.WalkingTo
{
	public class JT_WalkingTo : MonoBehaviour 
	{
		private JT_WalkingToSitting JT_WalkingToSitting;
		private JT_WalkingToStanding JT_WalkingToStanding;

		public void JT_WalkingToController()
		{
			Load_JT_WalkingToSitting();
			Load_JT_WalkingToStanding();
		}
		private void Load_JT_WalkingToSitting()
		{
			JT_WalkingToSitting.JT_WalkingToSittingController();
		}
		private void Load_JT_WalkingToStanding()
		{
			JT_WalkingToStanding.JT_WalkingToStandingController();
		}
	}
}