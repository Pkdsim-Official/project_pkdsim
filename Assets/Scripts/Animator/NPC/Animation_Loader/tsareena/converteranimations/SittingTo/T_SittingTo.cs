using project_pkdsim.ANIMATOR.NPC.Tsareena.converteranimations._SittingTo._SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Tsareena.converteranimations._SittingTo._SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Tsareena.converteranimations._SittingTo
{
	public class T_SittingTo : MonoBehaviour 
	{
		private T_SittingToStartWalking TsareenasittingToStartWalking;
		private T_SittingToStanding TsareenasittingToStanding;
		public void T_SittingToController()
		{
			T_SittingToStartWalking();
			T_SittingToStanding();
		}
		private void T_SittingToStartWalking()
		{
			TsareenasittingToStartWalking.T_SittingToStartWalkingController();
		}
		private void T_SittingToStanding()
		{
			TsareenasittingToStanding.T_SittingToStandingController();
		}

	}
}