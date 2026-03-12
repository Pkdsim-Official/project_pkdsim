using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.IdleTo
{
	public class TParentDad_IdleTo : MonoBehaviour 
	{
		private TParentDad_IdleToRun TsareenaParentDad_IdleToRun;
		private TParentDad_IdleToWalk TsareenaParentDad_IdleToWalk;
		public void TParentDad_IdleToController()
		{
			Load_TParentDad_idleToRun();
			Load_TParentDad_idleToWalk();
		}
		private void Load_TParentDad_idleToRun()
		{
			TsareenaParentDad_IdleToRun.TParentDad_IdleToRunController();
		}
		private void Load_TParentDad_idleToWalk()
		{
			TsareenaParentDad_IdleToWalk.TParentDad_IdleToWalkController();
		}
	}
}