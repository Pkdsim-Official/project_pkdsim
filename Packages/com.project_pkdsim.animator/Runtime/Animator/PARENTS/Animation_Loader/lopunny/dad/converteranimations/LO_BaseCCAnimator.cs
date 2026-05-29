using project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations
{
	public class Lopunny_ConverterToAnimatorController : MonoBehaviour 
	{
		private LOSittingTo Lopunnysittingto;
		
		private LOWalkingTo Lopunnywalkingto;
		
		private LOIdleTo Lopunnyidleto;

		public void LO_ConverterToAnimatorController()
		{
			Lopunnywalkingto.LOWalkingToController();

			Lopunnyidleto.LO_IdleToController();
			
			Lopunnysittingto.LOSittingToController();	
		}
	}
}