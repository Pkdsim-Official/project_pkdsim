using project_pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lunala.converteranimations
{
	public class LunalaCoverterAnimatorController : MonoBehaviour 
	{
		private LUNA_SittingTo Lunalasittingto;
		
		private LUNA_WalkingTo Lunalawalkingto;
		
		private LUNA_IdleTo Lunalaidleto;

		public void LUNACoverterToAnimatorController()
		{
			Lunalawalkingto.LUNA_WalkingToController();

			Lunalaidleto.LUNA_IdleToController();
			
			Lunalasittingto.LUNA_SittingToController();	
		}
	}
}