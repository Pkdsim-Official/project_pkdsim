using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.SittingTo
{
	public class LUNA_LFS_SittingTo : MonoBehaviour 
	{
		private LUNA_LFS_SittingToStartWalking Lunala_LFS_sittingToStartWalking;
		private LUNA_LFS_SittingToStanding Lunala_LFS_sittingToStanding;
		public void LUNA_LFS_SittingToController()
		{
			LUNA_LFS_SittingToStartWalking();
			LUNA_LFS_SittingToStanding();
		}
		private void LUNA_LFS_SittingToStartWalking()
		{
			Lunala_LFS_sittingToStartWalking.LUNA_LFS_SittingToStartWalkingController();
		}
		private void LUNA_LFS_SittingToStanding()
		{
			Lunala_LFS_sittingToStanding.LUNA_LFS_SittingToStandingController();
		}

	}
}