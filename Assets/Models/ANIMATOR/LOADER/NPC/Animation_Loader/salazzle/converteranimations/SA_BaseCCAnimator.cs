using project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations.IdleTo;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations.SittingTo;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations
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