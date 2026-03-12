using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo
{
	public class C_LFS_WalkingTo : MonoBehaviour 
	{
		private C_LFS_WalkingToSitting Cinderace_LFS_WalkingToSitting;
		private C_LFS_WalkingToStanding Cinderace_LFS_WalkingToStanding;
		public void C_LFS_WalkingToController()
		{
			C_LFS_WalkingToStartWalking();
			C_LFS_WalkingToStanding();
		}
		private void C_LFS_WalkingToStartWalking()
		{
			Cinderace_LFS_WalkingToSitting.C_LFS_WalkingToSittingController();
		}
		private void C_LFS_WalkingToStanding()
		{
			Cinderace_LFS_WalkingToStanding.C_LFS_WalkingToStandingController();
		}
	}
}