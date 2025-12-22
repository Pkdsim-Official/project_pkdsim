using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.IdleTo
{
	public class FLParentDadDad_IdleTo : MonoBehaviour 
	{
		private FLParentDadDad_IdleToRun FLParentDadDad_IdleToRun;
		private FLParentDadDad_IdleToWalk FLParentDadDad_IdleToWalk;
		public void FLParentDadDad_IdleToController()
		{
			Load_FLParentDadDad_IdleToRun();
			Load_FLParentDadDad_IdleToWalk();
		}
		private void Load_FLParentDadDad_IdleToRun()
		{
			FLParentDadDad_IdleToRun.FLParentDadDad_IdleToRunController();
		}
		private void Load_FLParentDadDad_IdleToWalk()
		{
			FLParentDadDad_IdleToWalk.FLParentDadDad_IdleToWalkController();
		}
	}
}