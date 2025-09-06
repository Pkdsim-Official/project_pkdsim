using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations.SittingTo
{
	public class LUCASittingTo : MonoBehaviour 
	{
		private LUCASittingToStartWalking LucariosittingToStartWalking;
		private LUCASittingToStanding LucariosittingToStanding;
		public void LUCASittingToController()
		{
			LUCASittingToStartWalking();
			LUCASittingToStanding();
		}
		private void LUCASittingToStartWalking()
		{
			LucariosittingToStartWalking.LUCASittingToStartWalkingController();
		}
		private void LUCASittingToStanding()
		{
			LucariosittingToStanding.LUCASittingToStandingController();
		}
	}
}