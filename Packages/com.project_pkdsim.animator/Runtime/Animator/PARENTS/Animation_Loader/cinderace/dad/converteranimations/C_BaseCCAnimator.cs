using project_pkdsim.ANIMATOR.Parents.Cinderace.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Cinderace.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Cinderace.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.converteranimations
{
	public class CinderaceParentDad_ConverterToAnimatorController : MonoBehaviour 
	{
		private C_SittingTo CinderaceSittingto;
		
		private C_WalkingTo CinderaceWalkingto;
		
		private C_IdleTo CinderaceIdleto;

		public void C_ConverterToAnimatorController()
		{
			CinderaceWalkingto.C_WalkingToController();

			CinderaceIdleto.C_IdleToController();
			
			CinderaceSittingto.C_SittingToController();	
		}
	}
}