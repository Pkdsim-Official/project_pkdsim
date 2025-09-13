using project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations.WalkingTo
{
	public class MEOW_WalkingTo : MonoBehaviour 
	{
		private MEOW_WalkingToSitting Meowscarada_WalkingToSitting;
		private MEOW_WalkingToStanding Meowscarada_WalkingToStanding;
		public void MEOW_WalkingToController()
		{
			MEOW_WalkingToSitting();
			MEOW_WalkingToStanding();
		}
		private void MEOW_WalkingToSitting()
		{
			Meowscarada_WalkingToSitting.MEOW_WalkingToSittingController();
		}
		private void MEOW_WalkingToStanding()
		{
			Meowscarada_WalkingToStanding.MEOW_WalkingToStandingController();
		}
	}
}