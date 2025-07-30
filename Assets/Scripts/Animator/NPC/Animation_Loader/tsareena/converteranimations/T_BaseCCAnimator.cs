using project_pkdsim.ANIMATOR.NPC.Tsareena.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Tsareena.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.NPC.Tsareena.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Tsareena.converteranimations
{
	public class Tsareena_CoverterAnimatorController : MonoBehaviour 
	{
		private T_SittingTo TsareenaSittingto;
		
		private T_WalkingTo TsareenaWalkingto;
		
		private T_IdleTo TsareenaIdleto;

		public void T_CoverterToAnimatorController()
		{
			TsareenaWalkingto.T_WalkingToController();

			TsareenaIdleto.T_IdleToController();
			
			TsareenaSittingto.T_SittingToController();	
		}
	}
}