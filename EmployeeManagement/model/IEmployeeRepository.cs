﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.model
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        void Save(Employee employee);
    }
}
