using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.IdleTo
{
	public class LUCAParentDad_IdleTo : MonoBehaviour 
	{
		private LUCAParentDad_IdleToRun LucarioParentDadIdleToRun;
		private LUCAParentDad_IdleToWalk LucarioParentDadIdleToWalk;

		public void LUCAParentDad_IdleToController()
		{
			Load_LUCAParentDad_idleToRun();
			Load_LUCAParentDad_idleToWalk();
		}
		private void Load_LUCAParentDad_idleToRun()
		{
			LucarioParentDadIdleToRun.LUCAParentDad_IdleToRunController();
		}
		private void Load_LUCAParentDad_idleToWalk()
		{
			LucarioParentDadIdleToWalk.LUCAParentDad_IdleToWalkController();
		}
	}
}