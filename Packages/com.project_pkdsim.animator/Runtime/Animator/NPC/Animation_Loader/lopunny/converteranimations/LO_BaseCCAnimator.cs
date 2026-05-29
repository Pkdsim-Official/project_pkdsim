using project_pkdsim.ANIMATOR.NPC.Lopunny.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Lopunny.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Lopunny.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lopunny.converteranimations
{
	public class Lopunny_ConverterToAnimatorController : MonoBehaviour 
	{
		private LO_SittingTo LopunnySittingto;
		
		private LO_WalkingTo LopunnyWalkingto;
		
		private LO_IdleTo LopunnyIdleto;

		public void LO_ConverterToAnimatorController()
		{
			LopunnyWalkingto.LO_WalkingToController();

			LopunnyIdleto.LO_IdleToController();
			
			LopunnySittingto.LO_SittingToController();	
		}
	}
}