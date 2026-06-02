using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.IdleTo
{
	public class ZParentDad_IdleTo : MonoBehaviour 
	{
		private ZParentDad_IdleToRun ZoroarkParentDad_IdleToRun;
		private ZParentDad_IdleToWalk ZoroarkParentDad_IdleToWalk;
		public void ZParentDad_IdleToController()
		{
			Load_ZParentDad_idleToRun();
			Load_ZParentDad_idleToWalk();
		}
		private void Load_ZParentDad_idleToRun()
		{
			ZoroarkParentDad_IdleToRun.ZParentDad_IdleToRunController();
		}
		private void Load_ZParentDad_idleToWalk()
		{
			ZoroarkParentDad_IdleToWalk.ZParentDad_IdleToWalkController();
		}
	}
}