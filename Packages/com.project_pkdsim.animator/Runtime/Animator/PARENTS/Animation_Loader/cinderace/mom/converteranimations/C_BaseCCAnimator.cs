using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations
{
	public class CinderaceParentMom_ConverterToAnimatorController : MonoBehaviour 
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