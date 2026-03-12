using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.IdleTo
{
	public class JTParentMom_IdleTo : MonoBehaviour 
	{
		private JTParentMom_IdleToRun JolteonParentMomIdleToRun;
		private JTParentMom_IdleToWalk JolteonParentMomIdleToWalk;

		public void JTParentMom_IdleToController()
		{
			Load_JTParentMom_idleToRun();
			Load_JTParentMom_idleToWalk();
		}
		private void Load_JTParentMom_idleToRun()
		{
			JolteonParentMomIdleToRun.JTParentMom_IdleToRunController();
		}
		private void Load_JTParentMom_idleToWalk()
		{
			JolteonParentMomIdleToWalk.JTParentMom_IdleToWalkController();
		}
	}
}