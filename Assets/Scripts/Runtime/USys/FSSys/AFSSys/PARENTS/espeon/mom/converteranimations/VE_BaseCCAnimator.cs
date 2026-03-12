using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations
{
	public class EspeonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private ESParentMom_SittingTo EspeonParentMomSittingto;
		
		private ESParentMom_WalkingTo EspeonParentMomWalkingto;
		
		private ESParentMom_IdleTo EspeonParentMomIdleto;

		public void ESParentMom_ConverterAnimatorController()
		{
			EspeonParentMomWalkingto.ESParentMom_WalkingToController();

			EspeonParentMomIdleto.ESParentMom_IdleToController();
			
			EspeonParentMomSittingto.ESParentMom_SittingToController();	
		}
	}
}