using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.converteranimations.IdleTo
{
	public class JTParentDad_IdleTo : MonoBehaviour 
	{
		private JTParentDad_IdleToRun JTParentDad_IdleToRun;
		private JTParentDad_IdleToWalk JTParentDad_IdleToWalk;
		
		public void JTParentDad_IdleToController()
		{
			Load_JTParentDad_idleToRun();
			Load_JTParentDad_idleToWalk();
		}
		private void Load_JTParentDad_idleToRun()
		{
			JTParentDad_IdleToRun.JTParentDad_IdleToRunController();
		}
		private void Load_JTParentDad_idleToWalk()
		{
			JTParentDad_IdleToWalk.JTParentDad_IdleToWalkController();
		}
	}
}