using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.IdleTo
{
	public class LEParentDad_IdleTo : MonoBehaviour
	{
		private LEParentDad_IdleToRun LeafeonParentDadIdleToRun;
		private LEParentDad_IdleToWalk LeafeonParentDadIdleToWalk;
		public void LEParentDad_IdleToController()
		{
			Load_LEParentDad_idleToRun();
			Load_LEParentDad_idleToWalk();
		}
		private void Load_LEParentDad_idleToRun()
		{
			LeafeonParentDadIdleToRun.LEParentDad_IdleToRunController();
		}
		private void Load_LEParentDad_idleToWalk()
		{
			LeafeonParentDadIdleToWalk.LEParentDad_IdleToWalkController();
		}
	}
}