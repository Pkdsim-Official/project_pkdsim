using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations
{
	public class NoivernParentDad_ConverterToAnimatorController : MonoBehaviour 
	{
		private NOISittingTo Noivernsittingto;
		
		private NOIWalkingTo Noivernwalkingto;
		
		private NOIIdleTo Noivernidleto;

		public void NOI_ConverterToAnimatorController()
		{
			Noivernwalkingto.NOIWalkingToController();

			Noivernidleto.NOI_IdleToController();
			
			Noivernsittingto.NOISittingToController();	
		}
	}
}