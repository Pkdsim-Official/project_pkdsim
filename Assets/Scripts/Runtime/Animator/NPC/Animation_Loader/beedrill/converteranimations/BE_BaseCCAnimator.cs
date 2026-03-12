using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Beedrill.converteranimations
{
	public class BeedrillCoverterAnimatorController : MonoBehaviour 
	{
		private BE_SittingTo BeedrillSittingto;
		
		private BE_WalkingTo BeedrillWalkingto;
		
		private BE_IdleTo BeedrillIdleto;

		public void BE_CoverterToAnimatorController()
		{
			BeedrillWalkingto.BE_WalkingToController();

			BeedrillIdleto.BE_IdleToController();
			
			BeedrillSittingto.BE_SittingToController();	
		}
	}
}