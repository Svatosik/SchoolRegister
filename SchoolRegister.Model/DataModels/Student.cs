﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels;

public class Student : User
{
    public double AverageGrade { get; }

    public IDictionary<string, double> AverageGradePerSubject { get; }

    public IList<Grade> Grades { get; set; }

    public IDictionary<string, List<GradeScale>>  GradesPerSubject { get; }

    public Group Group { get; set; }
    
    public int? GroupId { get; set; } = 0;

    public Parent Parent { get; set; }
    
    public int? ParentId { get; set; }
}
