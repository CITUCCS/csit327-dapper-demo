﻿using DapperExer1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExer1.Repositories
{
    /// <summary>
    /// Interface for school repository
    /// </summary>
    internal interface ISchoolRepository
    {
        School GetSchool(int id);
        IEnumerable<School> GetAllSchools();
        int AddSchool(School school);
        bool UpdateSchool(School school);
        bool DeleteSchool(int id);
    }
}