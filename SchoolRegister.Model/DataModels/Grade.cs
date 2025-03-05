using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels;

public class Grade
{
    public DateTime DateOfissue { get; set; }

    public GradeScale GradeValue { get; set; }

    public Student Student { get; set; }

    public int StudentId { get; set; }

    public Subject Subject { get; set; }

    public int SubjectId { get; set; }
}

public enum GradeScale
{
    NDST,
    DST,
    DB,
    BDB
}
