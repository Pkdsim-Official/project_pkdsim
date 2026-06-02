using project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.converteranimations
{
	public class Lopunny_ConverterAnimatorController : MonoBehaviour 
	{
		private LOSittingTo Lopunnysittingto;
		
		private LOWalkingTo Lopunnywalkingto;
		
		private LOIdleTo Lopunnyidleto;

		public void LO_ConverterAnimatorController()
		{
			Lopunnywalkingto.LOWalkingToController();

			Lopunnyidleto.LO_IdleToController();
			
			Lopunnysittingto.LOSittingToController();	
		}
	}
}