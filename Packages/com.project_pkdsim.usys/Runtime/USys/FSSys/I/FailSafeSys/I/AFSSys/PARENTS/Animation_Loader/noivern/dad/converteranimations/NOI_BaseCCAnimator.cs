using project_pkdsim.ANIMATOR.Parents.Noivern.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Noivern.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Noivern.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.converteranimations
{
	public class Noivern_ConverterToAnimatorController : MonoBehaviour 
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