using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.IdleTo
{
	public class NOIParentDad_IdleTo : MonoBehaviour
	{
		private NOIParentDad_IdleToRun NoivernIdleToRun;
		private NOIParentDad_IdleToWalk NoivernIdleToWalk;
		public void NOIParentDad_IdleToController()
		{
			NOIParentDad_IdleToRun();
			NOIParentDad_IdleToWalk();
		}
		private void NOIParentDad_IdleToRun()
		{
			NoivernIdleToRun.NOIParentDad_IdleToRunController();
		}
		private void NOIParentDad_IdleToWalk()
		{
			NoivernIdleToWalk.NOIParentDad_IdleToWalkController();
		}
	}
}