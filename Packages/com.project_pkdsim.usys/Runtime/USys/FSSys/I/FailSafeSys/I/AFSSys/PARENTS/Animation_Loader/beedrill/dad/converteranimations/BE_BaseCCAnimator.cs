using project_pkdsim.ANIMATOR.Parents.Beedrill.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Beedrill.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Beedrill.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.converteranimations
{
	public class Beedrill_ConverterToAnimatorController : MonoBehaviour 
	{
		private BE_SittingTo BeedrillSittingto;
		
		private BE_WalkingTo BeedrillWalkingto;
		
		private BE_IdleTo BeedrillIdleto;

		public void BE_ConverterToAnimatorController()
		{
			BeedrillWalkingto.BE_WalkingToController();

			BeedrillIdleto.BE_IdleToController();
			
			BeedrillSittingto.BE_SittingToController();	
		}
	}
}