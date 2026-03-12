using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.converteranimations.IdleTo
{
	public class UMParentDad_IdleTo : MonoBehaviour 
	{
		private UMParentDad_IdleToRun UmbreonParentDadIdleToRun;
		private UMParentDad_IdleToWalk UmbreonParentDadIdleToWalk;
		public void UMParentDad_IdleToController()
		{
			Load_UMParentDad_idleToRun();
			Load_UMParentDad_idleToWalk();
		}
		private void Load_UMParentDad_idleToRun()
		{
			UmbreonParentDadIdleToRun.UMParentDad_IdleToRunController();
		}
		private void Load_UMParentDad_idleToWalk()
		{
			UmbreonParentDadIdleToWalk.UMParentDad_IdleToWalkController();
		}
	}
}