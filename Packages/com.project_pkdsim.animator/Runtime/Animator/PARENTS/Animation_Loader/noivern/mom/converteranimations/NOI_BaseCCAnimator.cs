using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations
{
	public class NoivernParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private NOISittingTo Noivernsittingto;
		
		private NOIWalkingTo Noivernwalkingto;
		
		private NOIIdleTo Noivernidleto;

		public void NOI_ConverterAnimatorController()
		{
			Noivernwalkingto.NOIWalkingToController();

			Noivernidleto.NOI_IdleToController();
			
			Noivernsittingto.NOISittingToController();	
		}
	}
}