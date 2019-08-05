using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService1
{
    public class Pet
    {
        public int uID { get; set; }
        public string pName { get; set; }
        public int pLevel { get; set; }
        public int pDirtyPoint { get; set; }
        public int pHungerPoint { get; set; }
        public int balance { get; set; }
        public int exp { get; set; }
        public long cleanTime { get; set; }
        public long feedTime { get; set; }
        public long bathTime { get; set; }
        public long collectTime { get; set; }

        public Pet() { }
        public Pet(int uID, string pNmae, int pLevel, int pHungerPoint, int pDirtyPoint,int balance,int exp, long cleanTime,long feedTime,long bathTime,long collectTime)
        {
            this.uID = uID;
            this.pName = pName;
            this.pLevel = pLevel;
            this.pHungerPoint = pHungerPoint;
            this.pDirtyPoint = pDirtyPoint;
            this.balance = balance;
            this.exp = exp;
            this.cleanTime = cleanTime;
            this.feedTime = feedTime;
            this.bathTime = bathTime;
            this.collectTime=collectTime;

        }
    }
}