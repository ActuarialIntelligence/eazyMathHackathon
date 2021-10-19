using SchoolBook.Domain;
using SchoolBook.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Logic
{
    //     \[∫_\Δd\bo ω=∫_{∂\Δ}\bo ω\]

    public static class UniversityIntegration
    {
        //uv - ∫ v du
        public static string IntegrationByParts(IHomeworkParameters parameters)
        {
            var derivativeStore = new Dictionary<int, Pair<string,string>>();
            derivativeStore.Add(1, new Pair<string,string>("csc x", "- ln|csc x + cot x|"));
            derivativeStore.Add(2, new Pair<string, string>("b^x", "{b^x}/{ln(b)}"));
            derivativeStore.Add(3, new Pair<string, string>("ln|sec x + tan x|", "sec x"));
            derivativeStore.Add(4, new Pair<string, string>("ln(x)", "x ln(x) - x + C"));
            derivativeStore.Add(5, new Pair<string, string>("csc^2 x", "- cot x + C"));
            derivativeStore.Add(6, new Pair<string, string>(" sec x tan x", "sec x + C"));
            derivativeStore.Add(7, new Pair<string, string>(" sec2 x", " tan x + C"));
            derivativeStore.Add(8, new Pair<string, string>("arcsin x", "x arcsin x + √{1-x^2} + C"));
            derivativeStore.Add(9, new Pair<string, string>("arccsc x", "x arccos x - √{1-x^2} + C"));
            derivativeStore.Add(10, new Pair<string, string>("arctan x", "x arctan x - {1/2}* ln(1+x^2) + C"));
            derivativeStore.Add(11, new Pair<string, string>("1 /{ √{1 - x^2}}", "arcsin x + C"));
            derivativeStore.Add(12, new Pair<string, string>("1 /{x √{x^2 - 1}}", "arcsec|x| + C"));
            derivativeStore.Add(13, new Pair<string, string>("1 /{1 + x^2}", "arctan x + C"));

            //Let u=x and let v = key in the pair
            var rnd = new Random();
            var val = rnd.Next(1, 13);
            var v = derivativeStore[val].GetKey;
            var full = "" + derivativeStore[val].GetValue;
            return "∫"+"x*"+v +" dx"+"\n $ Answer :=" + "x*"+v+"-"+full ;
        }
    }
}
