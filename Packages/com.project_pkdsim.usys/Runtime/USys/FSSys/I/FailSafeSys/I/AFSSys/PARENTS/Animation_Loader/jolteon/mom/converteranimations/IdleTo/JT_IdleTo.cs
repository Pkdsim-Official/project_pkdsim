using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.IdleTo
{
	public class JTParentMom_IdleTo : MonoBehaviour 
	{
		private JTParentMom_IdleToRun JTParentMom_IdleToRun;
		private JTParentMom_IdleToWalk JTParentMom_IdleToWalk;
		
		public void JTParentMom_IdleToController()
		{
			Load_JTParentMom_idleToRun();
			Load_JTParentMom_idleToWalk();
		}
		private void Load_JTParentMom_idleToRun()
		{
			JTParentMom_IdleToRun.JTParentMom_IdleToRunController();			
		}
		private void Load_JTParentMom_idleToWalk()
		{
			JTParentMom_IdleToWalk.JTParentMom_IdleToWalkController();
		}
	}
}