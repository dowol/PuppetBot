using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot.Data;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
internal class PredefinedDataAttribute : Attribute
{
    internal PredefinedDataAttribute()
    {

    }
}

