using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer; 
using bussinessObject;

namespace bussinessLogic
{
  public  class ConferenceBL
    {
      public int SaveAddConferenceBL(ConferenceBO objconferenceBL) 
      {
          try
          {
              ConferenceDA objconferenceDA = new ConferenceDA();

              return objconferenceDA.AddConference(objconferenceBL); 

          }
          catch
          {
              throw;
          }
      }
    }
}
