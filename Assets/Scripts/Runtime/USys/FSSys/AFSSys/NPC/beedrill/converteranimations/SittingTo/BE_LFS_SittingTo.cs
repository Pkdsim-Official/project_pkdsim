using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo
{
	public class BE_LFS_SittingTo : MonoBehaviour 
	{
		private BE_LFS_SittingToStartWalking Beedrill_LFS_sittingToStartWalking;
		private BE_LFS_SittingToStanding Beedrill_LFS_sittingToStanding;
		public void BE_LFS_SittingToController()
		{
			BE_LFS_SittingToStartWalking();
			BE_LFS_SittingToStanding();
		}
		private void BE_LFS_SittingToStartWalking()
		{
			Beedrill_LFS_sittingToStartWalking.BE_LFS_SittingToStartWalkingController();
		}
		private void BE_LFS_SittingToStanding()
		{
			Beedrill_LFS_sittingToStanding.BE_LFS_SittingToStandingController();
		}
	}
}