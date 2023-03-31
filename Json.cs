using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;

namespace ConsoleGenericDemo
{

    [MemoryDiagnoser]
    public class Json
    {
        private List<Subject> list=new();
        public Json() {
            int count = 1000;
            for (int i = 0; i < count; i++)
            {
                list.Add(new Subject() { Name = $"s{i}", Semester = i });
            }
        }

        [Benchmark]
        public string MircosoftSerialize()
        {
            return System.Text.Json.JsonSerializer.Serialize(list);
        }

        [Benchmark]
        public string NewtonsoftSerialize()
        {
            return JsonConvert.SerializeObject(list);
        }
    }
}
