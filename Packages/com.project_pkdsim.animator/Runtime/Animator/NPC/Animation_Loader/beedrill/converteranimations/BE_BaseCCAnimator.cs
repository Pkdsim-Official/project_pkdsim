using project_pkdsim.ANIMATOR.NPC.Beedrill.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Beedrill.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Beedrill.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Beedrill.converteranimations
{
	public class Beedrill_ConverterAnimatorController : MonoBehaviour 
	{
		private BE_SittingTo BeedrillSittingto;
		
		private BE_WalkingTo BeedrillWalkingto;
		
		private BE_IdleTo BeedrillIdleto;

		public void BE_ConverterAnimatorController()
		{
			BeedrillWalkingto.BE_WalkingToController();

			BeedrillIdleto.BE_IdleToController();
			
			BeedrillSittingto.BE_SittingToController();	
		}
	}
}