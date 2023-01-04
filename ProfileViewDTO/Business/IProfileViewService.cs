using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileViewDTO.Business
{
    public interface IProfileViewService
    {
        public ViewProfilesDTO ViewProfiless(int ProfileId);
        public bool EditService(ViewProfilesDTO viewProfilesDTO);
    }
}
