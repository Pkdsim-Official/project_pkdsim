using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations
{
	public class DelphoxConverterAnimatorController : MonoBehaviour 
	{
		private DLSittingTo DelphoxSittingto;
		
		private DLWalkingTo DelphoxWalkingto;
		
		private DL_IdleTo DelphoxIdleto;

		public void DLConverterAnimatorController()
		{
			DelphoxWalkingto.DLWalkingToController();

			DelphoxIdleto.DL_IdleToController();
			
			DelphoxSittingto.DLSittingToController();	
		}
	}
}