using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations
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