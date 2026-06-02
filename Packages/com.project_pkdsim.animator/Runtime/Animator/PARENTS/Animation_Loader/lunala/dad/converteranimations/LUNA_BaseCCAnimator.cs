using project_pkdsim.ANIMATOR.Parents.Lunala.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lunala.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lunala.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Dad.converteranimations
{
	public class Lunala_ConverterAnimatorController : MonoBehaviour 
	{
		private LUNASittingTo Lunalasittingto;
		
		private LUNAWalkingTo Lunalawalkingto;
		
		private LUNAIdleTo Lunalaidleto;

		public void LUNA_ConverterAnimatorController()
		{
			Lunalawalkingto.LUNAWalkingToController();

			Lunalaidleto.LUNA_IdleToController();
			
			Lunalasittingto.LUNASittingToController();	
		}
	}
}