using Project_Pkdsim.ANIMATOR.Npcs.Salazzle.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Salazzle.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Salazzle.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Salazzle.converteranimations
{
	public class Salazzle_CoverterAnimatorController : MonoBehaviour 
	{
		private SA_SittingTo Salazzle_sittingto;
		
		private SA_WalkingTo Salazzle_walkingto;
		
		private SA_IdleTo Salazzle_idleto;

		public void SA_CoverterToAnimatorController()
		{
			Salazzle_walkingto.SA_WalkingToController();

			Salazzle_idleto.SA_IdleToController();
			
			Salazzle_sittingto.SA_SittingToController();	
		}
	}
}