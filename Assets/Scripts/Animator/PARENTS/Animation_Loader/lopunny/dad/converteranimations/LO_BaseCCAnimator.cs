using project_pkdsim.ANIMATOR.Parents.Lopunny.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lopunny.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lopunny.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.converteranimations
{
	public class LopunnyConverterAnimatorController : MonoBehaviour 
	{
		private LOSittingTo Lopunnysittingto;
		
		private LOWalkingTo Lopunnywalkingto;
		
		private LOIdleTo Lopunnyidleto;

		public void LOConverterToAnimatorController()
		{
			Lopunnywalkingto.LOWalkingToController();

			Lopunnyidleto.LO_IdleToController();
			
			Lopunnysittingto.LOSittingToController();	
		}
	}
}