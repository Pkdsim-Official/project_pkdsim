using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.IdleTo
{
	public class BRParentDad_IdleTo : MonoBehaviour 
	{
		private BRParentDad_IdleToRun BraixenIdleToRun;
		private BRParentDad_IdleToWalk BraixenIdleToWalk;
		public void BRParentDad_IdleToController()
		{
			Load_BRParentDad_IdleToRun();
			Load_BRParentDad_IdleToWalk();
		}
		private void Load_BRParentDad_IdleToRun()
		{
			BraixenIdleToRun.BRParentDad_IdleToRunController();
		}
		private void Load_BRParentDad_IdleToWalk()
		{
			BraixenIdleToWalk.BRParentDad_IdleToWalkController();
		}
	}
}