using project_pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations
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