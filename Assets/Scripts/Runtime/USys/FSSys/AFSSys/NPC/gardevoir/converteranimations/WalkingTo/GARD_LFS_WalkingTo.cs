using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo
{
	public class GARD_LFS_WalkingTo : MonoBehaviour 
	{
		private GARD_LFS_WalkingToSitting Gardevoir_LFS_WalkingToSitting;
		private GARD_LFS_WalkingToStanding Gardevoir_LFS_WalkingToStanding;
		public void GARD_LFS_WalkingToController()
		{
			GARD_LFS_WalkingToStartWalking();
			GARD_LFS_WalkingToStanding();
		}
		private void GARD_LFS_WalkingToStartWalking()
		{
			Gardevoir_LFS_WalkingToSitting.GARD_LFS_WalkingToSittingController();
		}
		private void GARD_LFS_WalkingToStanding()
		{
			Gardevoir_LFS_WalkingToStanding.GARD_LFS_WalkingToStandingController();
		}
	}
}