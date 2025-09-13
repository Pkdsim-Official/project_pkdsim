using project_pkdsim.ANIMATOR.Parents.Lunala.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Lunala.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Lunala.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.converteranimations
{
	public class LunalaCoverterAnimatorController : MonoBehaviour 
	{
		private LUNASittingTo Lunalasittingto;
		
		private LUNAWalkingTo Lunalawalkingto;
		
		private LUNAIdleTo Lunalaidleto;

		public void LUNACoverterToAnimatorController()
		{
			Lunalawalkingto.LUNAWalkingToController();

			Lunalaidleto.LUNA_IdleToController();
			
			Lunalasittingto.LUNASittingToController();	
		}
	}
}