using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        // This is where criteria, and returns boolean
        Expression<Func<T, bool>> criteria { get; set; }

        // This returns object
        List<Expression<Func<T, object>>> Includes { get; }
    }
}
