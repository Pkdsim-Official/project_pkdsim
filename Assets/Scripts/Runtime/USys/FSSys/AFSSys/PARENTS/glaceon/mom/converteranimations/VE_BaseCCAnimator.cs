using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations
{
	public class GlaceonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private GLParentMom_SittingTo GlaceonParentMomSittingto;
		
		private GLParentMom_WalkingTo GlaceonParentMomWalkingto;
		
		private GLParentMom_IdleTo GlaceonParentMomIdleto;

		public void GLParentMom_ConverterAnimatorController()
		{
			GlaceonParentMomWalkingto.GLParentMom_WalkingToController();

			GlaceonParentMomIdleto.GLParentMom_IdleToController();
			
			GlaceonParentMomSittingto.GLParentMom_SittingToController();	
		}
	}
}