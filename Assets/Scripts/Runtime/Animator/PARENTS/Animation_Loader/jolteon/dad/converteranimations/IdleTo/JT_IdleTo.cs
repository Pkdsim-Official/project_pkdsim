using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations.IdleTo
{
	public class JTParentDad_IdleTo : MonoBehaviour 
	{
		private JTParentDad_IdleToRun JolteonParentDadIdleToRun;
		private JTParentDad_IdleToWalk JolteonParentDadIdleToWalk;
		
		public void JTParentDad_IdleToController()
		{
			Load_JTParentDad_idleToRun();
			Load_JTParentDad_idleToWalk();
		}
		private void Load_JTParentDad_idleToRun()
		{
			JolteonParentDadIdleToRun.JTParentDad_IdleToRunController();
		}
		private void Load_JTParentDad_idleToWalk()
		{
			JolteonParentDadIdleToWalk.JTParentDad_IdleToWalkController();
		}
	}
}