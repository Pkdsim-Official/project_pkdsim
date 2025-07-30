using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations
{
	public class FrostlassParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private FRParentMom_SittingTo FrostlassParentMomSittingto;
		
		private FRParentMom_WalkingTo FrostlassParentMomWalkingto;
		
		private FRParentMom_IdleTo FrostlassParentMomIdleto;

		public void FRParentMom_ConverterAnimatorController()
		{
			FrostlassParentMomWalkingto.FRParentMom_WalkingToController();

			FrostlassParentMomIdleto.FRParentMom_IdleToController();
			
			FrostlassParentMomSittingto.FRParentMom_SittingToController();	
		}
	}
}