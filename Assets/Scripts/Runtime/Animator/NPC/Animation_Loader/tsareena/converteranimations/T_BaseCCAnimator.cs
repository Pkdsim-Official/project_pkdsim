using Project_Pkdsim.ANIMATOR.Npcs.Tsareena.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Tsareena.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Tsareena.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Tsareena.converteranimations
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