using System;
using System.Linq;
using System.Collections.Generic;

namespace Module3Part1
{
    class Website
    {
        private string name, path, description, ip;
        public void SetData(string name,string path,string desc,string ip){ this.name=name; this.path=path; description=desc; this.ip=ip; }
        public void ShowData()=>Console.WriteLine($"{name} {path} {description} {ip}");
        public string Name{get=>name; set=>name=value;}
        public string IP{get=>ip; set=>ip=value;}
    }

    class Journal
    {
        private string name, description, phone, email;
        private int year;
        public void SetData(string name,int year,string desc,string phone,string email){ this.name=name; this.year=year; description=desc; this.phone=phone; this.email=email; }
        public void ShowData()=>Console.WriteLine($"{name} {year} {description} {phone} {email}");
    }

    class Shop
    {
        private string name, address, profile, phone, email;
        public void SetData(string name,string address,string profile,string phone,string email){ this.name=name; this.address=address; this.profile=profile; this.phone=phone; this.email=email; }
        public void ShowData()=>Console.WriteLine($"{name} {address} {profile} {phone} {email}");
    }

    class ForeignPassport
    {
        public string PassportNumber{get; set;}
        public string Name{get; set;}
        public DateTime IssueDate{get; set;}
        public ForeignPassport(string number,string name,DateTime date){
            if(string.IsNullOrWhiteSpace(number)) throw new ArgumentException("Invalid number");
            PassportNumber=number; Name=name; IssueDate=date;
        }
        public void Show()=>Console.WriteLine($"{PassportNumber} {Name} {IssueDate.ToShortDateString()}");
    }

    class Program
    {
        static void PrintSquare(int size,char c){ for(int i=0;i<size;i++){ for(int j=0;j<size;j++) Console.Write(c); Console.WriteLine(); } }
        static bool IsPalindrome(int n){ var s=n.ToString(); return s==new string(s.Reverse().ToArray()); }
        static int[] FilterArray(int[] original,int[] filter)=>original.Where(x=>!filter.Contains(x)).ToArray();
        static long MultiplyRange(int a,int b){ long prod=1; for(int i=a;i<=b;i++) prod*=i; return prod; }
        static bool IsFibonacci(int n){ int a=0,b=1;if(n==0||n==1) return true; while(b<n){int t=a+b;a=b;b=t;} return b==n; }
        static int[] SortArray(int[] arr,bool ascending){ for(int i=0;i<arr.Length;i++) for(int j=i+1;j<arr.Length;j++){ if(ascending?arr[i]>arr[j]:arr[i]<arr[j]){ int t=arr[i]; arr[i]=arr[j]; arr[j]=t; } } return arr; }
        static int StringToInt(string s){ if(!int.TryParse(s,out int res)) throw new OverflowException(); return res; }
        static int BinaryStringToInt(string s){ try{ return Convert.ToInt32(s,2);} catch{ throw new OverflowException(); } }
        static int WordToDigit(string word){ var dict=new Dictionary<string,int>{{"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},{"five",5},{"six",6},{"seven",7},{"eight",8},{"nine",9}}; if(dict.ContainsKey(word.ToLower())) return dict[word.ToLower()]; else throw new ArgumentException(); }
        static int EvaluateMultiplication(string expr){ var parts=expr.Split('*'); int res=1; foreach(var p in parts){ if(!int.TryParse(p,out int n)) throw new ArgumentException(); res*=n; } return res; }
    }
}
