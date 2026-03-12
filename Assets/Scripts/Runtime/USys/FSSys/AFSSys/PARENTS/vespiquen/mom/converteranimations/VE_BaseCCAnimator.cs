using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class VespiquenParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo VespiquenParentMomSittingto;
		
		private VEParentMom_WalkingTo VespiquenParentMomWalkingto;
		
		private VEParentMom_IdleTo VespiquenParentMomIdleto;

		public void VEParentMom_ConverterAnimatorController()
		{
			VespiquenParentMomWalkingto.VEParentMom_WalkingToController();

			VespiquenParentMomIdleto.VEParentMom_IdleToController();
			
			VespiquenParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}