using System;
using System.Collections.Generic;

namespace StateCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var states = new List<State>()
            {
                new State("OH", "Ohio"),
                new State("IN", "Indiana"),
                new State("KY", "Kentucky")
            };
                //var stateoh = new State("OH", "Ohio");
                //states.Add(stateoh);
                //var stateky = new State("KY", "Kentucky");
                //states.Add(stateky);
                
                //states.Add(new State("IN", "Indiana"));

            foreach (var STE in states)
            {
                Console.WriteLine($"The State code {STE.Code} is representing {STE.Name}");
            }





            //var statecodes = new Dictionary<string, string>()
            //{ 
            //    ["OH"] = "Ohio", ["KY"] = "Kentucky", ["IN"] = "Indiana"
            //};
            //statecodes.Add("OH", "Ohio");
            //statecodes.Add("IN", "Indiana");
            //statecodes.Add("KY", "Kentucky");

            //var ohio = statecodes["OH"];
            //Console.WriteLine(ohio);
        }
    }
}
