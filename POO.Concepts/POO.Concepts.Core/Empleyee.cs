using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core;

public abstract class Empleyee
{
    public int Id
    {
        get;
        set;
    }
    public string FirstName
    {
        get;
        set;
    } = null!;

    public string LastName
    {
        get;
        set;
    } = null!;
    public bool IsActive
    {
        get;
        set;
    }

    public Date HireDate
    {
        get;
        set;
    } = null!;
    public Date bornDate
    {
        get;
        set;
    } = null!;
    public abstract decimal GetValueToPay();

    public override string ToString() =>
        $"{Id}\t{FirstName}  {LastName}\n\t" +
        $"Hire date..: {HireDate}\n\t" +
        $"Salary.....: {GetValueToPay():C2}";



} 


  










