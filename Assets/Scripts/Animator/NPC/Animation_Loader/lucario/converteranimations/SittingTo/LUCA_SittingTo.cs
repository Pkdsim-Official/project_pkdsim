using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.SittingTo
{
	public class LUCA_SittingTo : MonoBehaviour 
	{
		private LUCA_SittingToStartWalking LucariosittingToStartWalking;
		private LUCA_SittingToStanding LucariosittingToStanding;
		public void LUCA_SittingToController()
		{
			LUCA_SittingToStartWalking();
			LUCA_SittingToStanding();
		}
		private void LUCA_SittingToStartWalking()
		{
			LucariosittingToStartWalking.LUCA_SittingToStartWalkingController();
		}
		private void LUCA_SittingToStanding()
		{
			LucariosittingToStanding.LUCA_SittingToStandingController();
		}
	}
}