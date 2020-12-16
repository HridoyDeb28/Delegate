using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Delegate_A_
{
    class Sample
    {
        public void MethodToBeReferred1(int i)
        {
            Console.WriteLine("MethodToBeReferred1:"+(i+2));
        }

        public void MethodToBeReferred2(int i)
        {
            Console.WriteLine("MethodToBeReferred2:" +(i*2));
        }
        public void MethodToBeReferred3(int i)
        {
            Console.WriteLine("MethodToBeReferred3:" + (i-2));
        }


    }

    public delegate void DelegateForSample(int a);
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            //DelegateForSample dfs = new DelegateForSample(s.MethodToBeReferred);
            //DelegateForSample dfs = s.MethodToBeReferred1;
            //dfs = dfs + s.MethodToBeReferred2;
            //dfs += s.MethodToBeReferred2;
            //dfs += s.MethodToBeReferred3;


            //dfs -=s.MethodToBeReferred2;
            //dfs.Invoke(50);
            //dfs(20);
            //dfs(15);
            DelegateForSample dfs1 = s.MethodToBeReferred1;
            DelegateForSample dfs2 = s.MethodToBeReferred2;
            DelegateForSample dfs3 = s.MethodToBeReferred3;
            DelegateForSample dfs = dfs1 + dfs2 + dfs2 + dfs3 - dfs2;
            dfs(30);


        }
       
    }
}
