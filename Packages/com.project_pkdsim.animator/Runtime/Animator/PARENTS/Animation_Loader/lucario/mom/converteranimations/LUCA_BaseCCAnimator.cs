using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations
{
	public class Lucario_ConverterToAnimatorController : MonoBehaviour 
	{
		private LUCASittingTo Lucariosittingto;
		
		private LUCAWalkingTo Lucariowalkingto;
		
		private LUCAIdleTo Lucarioidleto;

		public void LUCA_ConverterToAnimatorController()
		{
			Lucariowalkingto.LUCAWalkingToController();

			Lucarioidleto.LUCA_IdleToController();
			
			Lucariosittingto.LUCASittingToController();	
		}
	}
}