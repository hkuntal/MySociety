﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using HRS.Projects.MySociety.BusinessObjects;

namespace HRS.Projects.MySociety.WCFServices
{
    [ServiceContract]
    public interface IResidentSvc
    {
        Flat GetFlatDetails(int societyId);

    }
}
