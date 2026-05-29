using project_pkdsim.ANIMATOR.Parents.Lunala.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lunala.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lunala.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.converteranimations
{
	public class Lunala_ConverterToAnimatorController : MonoBehaviour 
	{
		private LUNASittingTo Lunalasittingto;
		
		private LUNAWalkingTo Lunalawalkingto;
		
		private LUNAIdleTo Lunalaidleto;

		public void LUNA_ConverterToAnimatorController()
		{
			Lunalawalkingto.LUNAWalkingToController();

			Lunalaidleto.LUNA_IdleToController();
			
			Lunalasittingto.LUNASittingToController();	
		}
	}
}